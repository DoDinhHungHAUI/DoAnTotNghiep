<template>  

<div>
    
    <ProductToolbarComponent 
        v-on:showDialogProduct = "showDialogProduct"
        v-on:setIsProduct = "setIsProduct"
    />
    <ProductGridComponent v-bind:products ="products" />
    
    <ProductPopupComponent 
        v-if="showDialog"
        v-bind:productCategory = "productCategory" 
        v-on:itemComboboxClick = "itemComboboxClick"
        v-on:confirmHidedDialog = "confirmHidedDialog"
        v-bind:isAddOrEdit = "isAddOrEdit"
        v-bind:listFieldNotValidRequired = "ListFieldNotValidRequired"
        v-on:hidedDialogProduct = "hidedDialogProduct"
        v-on:showToastSuccess = "showToastSuccess"
    />

    <PopupConfirmComponent 
        v-show = "isShowDialogConfirm"
        v-bind:messageConfirm = "messageConfirm"
        v-bind:isCancelSaveConfirm = "isCancelSaveConfirm"
        v-bind:isDeleteConfirm = "isDeleteConfirm"
        v-on:btnHideDialogConfirm = "btnHideDialogConfirm"
        v-on:btnNotHideDialogConfirm = "btnNotHideDialogConfirm"
        v-on:updateProduct = "updateProduct"
    />
    
    <ToastSuccessComponent v-show = "isShowToastSuccess" v-bind:messageSuccess = "messageSuccess" />

</div>  
</template>

<script>


/* Import Component */

import ProductGridComponent from './Grid/ProductGridComponent.vue'
import ProductToolbarComponent from './Toolbar/ProductToolbarComponent.vue'
import ProductPopupComponent from './Popup/ProductPopupComponent.vue'
import PopupConfirmComponent from './Popup/PopupConfirmComponent.vue'

import ToastSuccessComponent from './Toast/ToastSuccessComponent.vue'

/* Import library */
import axios from 'axios'

/* File Javascript */
import {Resource} from '../assets/js/common/resource'
import {CommonFunction} from '../assets/js/common/commonFunction'
import {Enum} from '../assets/js/common/Enum'


export default {
    name : "product-compoment",
    components : {
    ProductGridComponent,
    ProductToolbarComponent,
    ProductPopupComponent,
    PopupConfirmComponent,
    ToastSuccessComponent
},
    data(){
        return{
            products : [],
            productCategory : [],
            isShowDialogConfirm : false,
            showDialog : false,
            isCancelSaveConfirm : false,
            isDeleteConfirm : false,
            isAddOrEdit : Enum.FormModel.View,
            /**
             * danh sách các trường chưa valid bắt buộc nhập khi lưu dữ liệu
             */
            ListFieldNotValidRequired : [],
            isShowToastSuccess : false,
        }
    },

    methods : {
        
        /**
         * Method dùng để show toast thông báo Thêm/Sửa thành công nhân viên
         * CreatedBy : DDHung
         */
        showToastSuccess : function(message){
            try {
                this.messageSuccess = message;
                this.isShowToastSuccess = true;
                setTimeout(() => {
                    this.isShowToastSuccess = false
                } , 3000)
            } catch (error) {
                console.log(error);
            }
        },

        /**
         * Method Load dữ liệu grid
         * CreatedBy : DDHung 31/07/2022
        */
        updateProduct : function()
        {
            this.getData();
        },  

        /**
         * Method ẩn dialog nhập liệu
         * CreatedBy : DDHung 31/07/2022
        */
        hidedDialogProduct : function()
        {
            this.showDialog = false;
        },


        /**
         * Method xác nhận việc hủy đóng popup thêm/sửa sản phẩm
         * CreatedBy : DDHung 
        */
        btnNotHideDialogConfirm : function()
        {
            try {
                this.isShowDialogConfirm = false;
                this.isCancelSaveConfirm = false;
                this.isDeleteConfirm = false;
            } catch (error) {
                console.log(error);
            }
        },


        /**
         * Method dùng để đóng popup thêm/sửa sản phẩm
         * CreatedBy : DDHung
        */
        btnHideDialogConfirm : function(){
            try {
                this.isShowDialogConfirm = false;
                this.showDialog = false;
                //Ẩn bỏ các button của dialog confirm
                this.isCancelSaveConfirm = false;
                this.isDeleteConfirm = false;
            } catch (error) {
                console.log(error);
            }
        },

        /*      
        * method hiển thị dialog confirm cho người dùng về việc đóng popup thêm/sửa sản phẩm
        * CreatedBy : DDHung
        */
        confirmHidedDialog : function(message , isCancelSaveConfirm){
            try {
                this.isShowDialogConfirm = true;
                this.messageConfirm = message;
                this.isCancelSaveConfirm = isCancelSaveConfirm;
            } catch (error) {
                console.log(error);
            }
        },

        /**
         * Method thực hiện việc selected các item của combobox
         * CreatedBy : DDHung 
         */
        itemComboboxClick(data){
      
            CommonFunction.selectedItemCombobox(data);
        },

        /**
         * Lấy danh sách sản phẩm
         * CreatedBy : DDHung (30/07/2022)
        */
        getData(){
            var me = this;
            this.isShowLoader = true;
            axios.get(Resource.API.Host + Resource.API.GetProductApi)
            .then(res => {
                me.products = res.data;
            })
            .catch(error => {
                console.log(error)
            })
        },

        /**
         * Lấy danh sách danh mục sản phẩm
         * CreatedBy : DDHung (30/07/2022)
        */
        getProductCategories(){
            var me = this;
            axios.get(Resource.API.Host + Resource.API.GetProductCategory)
            .then(res => {
                me.productCategory = res.data.result;
            })
            .catch(error => {
                console.log(error)
            })
        },


        /**
         * Method thực hiện show dialog chi tiết sản phẩm
         * createdBy : DDHung 
        */
        showDialogProduct(){
             
            this.showDialog = true;
        },

        /**
         * Method dùng để đánh dấu là thêm sản phẩm
         * CreatedBy : DDHung 
         */
        setIsProduct()
        {
            this.isAddOrEdit = Enum.FormModel.Add;
        }


    },

    created() {
        this.getData();
        this.getProductCategories();
    },
}
</script>

<style>

</style>