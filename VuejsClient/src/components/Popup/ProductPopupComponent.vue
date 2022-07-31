<template>
    <div class="m-popup toggle-popup">
        <div class="wrap-popup"></div>
        <div class="popup-info-assets">
            <div class="header-popup">
                Thông tin sản phẩm  
                <button class="close-popup" id="close-popup" v-on:click="hidedDialogProduct"></button>
            </div>
            <div class="content-popup" ref="contentPopup">
                <div class = "form-product form-product-first">
                    <div class="input-form first-input-form">
                        <label>Tên sản phẩm<span style="color: red;">*</span></label><br />
                        <input 
                            type="text" class="input-popup-left first-field-popup input-text" 
                            fieldName = "ProductName"  
                            title = ""
                            v-model = "product.ProductName"
                            required
                            @blur = "validateFieldRequired($event)"
                            nameToValidate = "Tên sản phẩm"
                        />
                        <span class="tooltiptext"></span>
                    </div>
                    <div class="input-form first-input-form">
                        <label>Loại sản phẩm <span style="color: red;">*</span></label><br />
                        <!-- <input 
                            type="text" class="input-popup-right input-text"
                        /> -->
                        <ComboboxComponent 
                            v-bind:dataCombobox ="productCategory" 
                            v-bind:idItem = "'productCategoryId'" 
                            v-bind:nameItem = "'productCategoryName'"
                            v-on:itemComboboxClick = "itemComboboxClick"
                            v-bind:nameToValidate = "'Loại sản phẩm'"
                            v-bind:required = true
                        />

                        <span class="tooltiptext fixedAssetName-tooltiptext"></span>
                    </div>
                </div>
                
                <div class="form-product">
                     <div class="input-form first-input-form">
                        <label>Giá sản phẩm<span style="color: red;">*</span></label><br />
                        
                        <input 
                            type="text" 
                            class="input-popup-right input-text"  
                            fieldName = "Price" 
                            v-model = "product.Price"
                            required
                            @blur = "validateFieldRequired($event)"
                            @keydown="restricCharacter($event)" 
                            nameToValidate = "Giá sản phẩm"
                            ref="Price"
                            
                        />
                        <span class="tooltiptext"></span>
                    </div>
                    <div class="input-form first-input-form">
                        <label>Giá khuyến mại </label><br />
                        <input 
                            type="text" class="input-popup-right input-text" 
                            fieldName = "PromotionPrice" 
                            v-model = "product.PromotionPrice"
                            @keydown="restricCharacter($event)" 
                            ref="PromotionPrice"
                        />
                        <span class="tooltiptext fixedAssetName-tooltiptext"></span>
                    </div>
                </div>

                <div class="form-product">
                     <div class="input-form first-input-form">
                        <label>Số lượng<span style="color: red;">*</span></label><br />
                        
                        <input 
                            type="text" class="input-popup-right input-text" 
                            fieldName = "Quantity" 
                            v-model = "product.Quantity"
                            required
                            @blur = "validateFieldRequired($event)"
                            nameToValidate = "Số lượng"
                            @keydown="restricCharacter($event)"
                        />
                        <span class="tooltiptext"></span>
                    </div>
                    <div class="input-form first-input-form">
                        <label>Bảo hành </label><br />
                        <input 
                            type="text" class="input-popup-right input-text" 
                            fieldName = "Warranty"
                            v-model = "product.Warranty"
                            @keydown="restricCharacter($event)"
                        />
                        <span class="tooltiptext fixedAssetName-tooltiptext"></span>
                    </div>
                </div>
                
                <div class="form-product">
                     <div class="input-form first-input-form">
                        <label>Alias </label><br />
                        
                        <input 
                            type="text" class="input-popup-right input-text" 
                            fieldName = "Alias"
                            v-model = "product.Alias"
                        />
                        <span class="tooltiptext"></span>
                    </div>
                    <div class="input-form first-input-form">
                        <label>Hình ảnh <span style="color: red;">*</span></label><br />
                        <input style="display: none" type="file" ref="fileInput" @change="onFilePicked" />
                        <!-- <input 
                            type="text" class="input-popup-right input-text"
                        /> -->
                        <button type="button" class="btn btn-primary" v-on:click="onPickFile">Chọn hình ảnh</button>
                        <span class="tooltiptext fixedAssetName-tooltiptext"></span>
                    </div>
                </div>

                <div class="form-product">
                     <div class="input-form text-full-form">
                        <label>Mô tả </label><br />
                        
                        <textarea 
                            class="textarea-popup-right input-text" 
                            fieldName = "Content"
                            v-model = "product.Content"
                        ></textarea>
                        <span class="tooltiptext"></span>
                    </div>
                </div>

            </div>
            <div class="footer-popup">
                <div class="wrap-button-footer">
                    <button type="button" class="m-btn-cancel" id="btn-close-popup" v-on:click = "hidedDialogProduct">
                        Hủy
                    </button>
                    <button type="button" class="m-btn m-btn-save" id="btnSave" v-on:click = "btnSaveClick">
                        Lưu
                    </button>
                </div>
            </div>
        </div>
    </div>
</template>


<script>

import axios from 'axios'

/* Import file js */

import {Enum} from '../../assets/js/common/Enum' 
import {CommonFunction} from '../../assets/js/common/commonFunction' 
import {Resource} from '../../assets/js/common/resource' 
import {Common} from '../../assets/js/common/common' 
import {ToastJS} from '../../assets/js/common/toastJs'

/* Import Component */
import ComboboxComponent from '../Base/ComboboxComponent.vue'
// import InputTypeNumberComponent from '../Base/InputTypeNumberComponent.vue'


export default {
    data(){
        return{
            checkValidate : false,
            product : {
                ProductName : "",
                CategoryID : "",
                Price : 0,
                PromotionPrice : 0,
                Quantity : 0,
                Warranty : 0,
                Alias : 0,
                Image : "",
                Content : ""    
            },
            fileUpload : null
        }
    },

    props :{
        productCategory : {
            type : Array
        },
        isAddOrEdit : {
            type : Number
        },
        listFieldNotValidRequired : {
            type : Array
        }
    },

    methods : {
        
        /**
         * Xử kiện xử lý việc nhập khẩu dữ liệu từ file execl
         * CreatedBy : DDHung (23/11/2021)
        */
        onFilePicked : function(event)
        {
            try {
                let files = event.target.files;
                this.fileUpload = files[0];
                console.log(this.fileUpload);
                
            } catch (error) {
                console.log(error);
            }
        },


        /**
         * Sự kiện được sử dụng cho việc upload file 
         * CreatedBy : DDHung 
        */
        onPickFile : function()
        {
            this.$refs.fileInput.click();
        },



        /**
         * Method hạn chế nhập ký tự character vào các ô nhập vào là chữ số
         * CreatedBy : DDHung (16/11/2021)
        */
        restricCharacter : function(e){
            if ((/^\d*$/.test(e.key) == false && e.keyCode != 8 && e.keyCode != 9) || e.key < 0) {
                e.preventDefault();
            }
        },


        /**
         * Method thực hiện validate các trường bắt buộc nhập
         * CreatedBy : DDHung
        */
        validateFieldRequired : function(event){
            try {

                var self = this;
                var input = event.target;
                var fieldName = input.getAttribute('fieldname');
                var nameToValidate = input.getAttribute('nameToValidate');
                var value = this.product[fieldName];
                var tootlTip = input.parentElement.querySelector('.tooltiptext');
                if(input.classList.contains("input-typenumber-popup"))
                {
                    tootlTip = input.parentElement.parentElement.querySelector('.tooltiptext');
                }
                //Bắt buộc nhập
                if(!value){
                    self.listFieldNotValidRequired.push(nameToValidate);
                    input.classList.add('border-red');
                    tootlTip.classList.add("showTooltip")
                    tootlTip.innerText = Resource[Common.LanguageCode].Validate.Required(nameToValidate);
                    input.setAttribute('validate' , false)
                    this.checkValidate = false;
                }
                else{
                    input.classList.remove('border-red');
                    tootlTip.classList.remove("showTooltip")
                    input.removeAttribute('validate')
                }
            } catch (error) {
                console.log(error)
            }
        },

        /**
         * Method thực hiện close Popup form chi tiết sản phẩm
         * CreatedBy : DDHung 
        */
        hidedDialogProduct(){
            this.$emit('confirmHidedDialog', Resource[Common.LanguageCode].MessageDialogConfirm.ConfirmHidePopupProduct, true);
        },

        /**
         * Method xử lý khi selected 1 giá trị của combobox
         * CreatedBy : DDHung (16/11/2021)
        */
        itemComboboxClick(id ,name , event){
            
            try {
                var data = {
                    name : name,
                    id : id,
                    event : event
                }
                var cbItem;
                if(event.target)
                {
                    cbItem = event.target;
                }else{
                    cbItem = event;
                }
                
                var combobox = cbItem.parentElement.parentElement;
                // var fieldName = cbItem.parentElement.parentElement.getAttribute('fieldName')
                var fieldName = combobox.getAttribute('nameId')
               
                this.product[fieldName] = id;
                this.product.CategoryID = id;
                if(this.product[fieldName])
                {
                    combobox.classList.remove('border-red');
                    var toolTip =  combobox.parentElement.querySelector(".tooltiptext");
                    toolTip.classList.remove("showTooltip");
                    combobox.removeAttribute('validate')
                }
                this.$emit('itemComboboxClick' , data);
            } catch (error) {
                console.log(error)
            }
        },

        /**
         * Method thực hiện việc Thêm/Sửa sản phẩm
         * CreatedBy : DDHung 
        */
        btnSaveClick(){
            try {
                var me = this;
                this.checkValidate = true;
                var dialogContent =  this.$refs.contentPopup;
                var inputRequires = dialogContent.querySelectorAll('input[required]');
                for(let inputRequired of inputRequires)
                {
                    inputRequired.focus();
                    inputRequired.blur();
                }
                me.validateComboboxRequired();
            
                var newProduct = CommonFunction.createObjectToAddOrEdit(this.product); 
                
                if(this.checkValidate)
                {
                    if(this.isAddOrEdit == Enum.FormModel.Add || this.isAddOrEdit == Enum.FormModel.Replication)
                    {
                        let formData = new FormData();
                        formData.append('formFile',this.fileUpload);
                        formData.append('product',JSON.stringify(newProduct));

                        axios.post("https://localhost:44397/api/v1/Product/AddNewProduct" , formData, { headers: {'Content-Type': 'multipart/form-data'}})
                        .then(() => {
                            this.$emit('hidedDialogProduct');
                            this.$emit('updateProduct');
                            this.$emit('showToastSuccess' , ToastJS.successMessage);
                        })
                        .catch(error => {
                            if(error.response.status == 400){
                                // this.$emit('showDialogNotValid' , error.response.data.Data.userMsg)
                            }
                            else{
                                // this.$emit('showDialogNotValid' ,ToastJS.errorMessage)
                                // console.log("There was an error!", error);
                            }
                        })
                    }else{

                        // //Confirm trước khi sửa
                        // this.$emit("confirmSaveInfoFixedAsset" , Resource[Common.LanguageCode].MessageDialogConfirm.ConfirmSaveInfo , true)
                        
                        // //Gửi dữ liệu thay đổi lên Component FixedAssetPage để khi bấm xác nhận lưu thì sẽ lưu dữ liệu đó xuống database
                        // this.$emit("transmitFixedAsset" , this.fixedAsset) 
                    }
                }else{
                    
                
                    var inputNotValid = dialogContent.querySelectorAll('input[validate="false"]')
                    inputNotValid[0].focus();
                }
            } catch (error) {
                console.log(error)
            }
        },

        /**
         * Method thực hiện validate các combobox bắt buộc chọn
         * CreatedBy : DDHung
        */
        validateComboboxRequired : function()
        {
            var self = this;
            try {
                var dialogContent =  this.$refs.contentPopup;
                var comboboxRequired = dialogContent.querySelectorAll('.comboboxRequired');
            
                for(let element of comboboxRequired)
                {
                    var nameIdCombobox =  element.getAttribute("nameId");
                    var nameToValidate = element.getAttribute("nameToValidate");
                    var toolTip = element.parentElement.querySelector(".tooltiptext");
                    if(!this.product[nameIdCombobox])
                    {
                        self.listFieldNotValidRequired.push(nameToValidate);
                        element.classList.add('border-red');
                       
                        toolTip.classList.add("showTooltip");
                        toolTip.innerText = Resource[Common.LanguageCode].Validate.Required(nameToValidate);

                        element.firstElementChild.setAttribute('validate' , false);
                        this.checkValidate = false;
                    }else{
                        element.classList.remove('border-red');
                        toolTip.classList.remove("showTooltip");
                        element.firstElementChild.removeAttribute('validate')
                    }
                }
            } catch (error) {
                console.log(error);
            }
        },

    },

    components:{
        ComboboxComponent,
    },

    watch : {
        'product.Price' : function(val){
            try{
                var value = CommonFunction.convertMoneyToNumber(val);
               
                var input = this.$refs.Price;
                var tootlTip = input.parentElement.querySelector('.tooltiptext');
                if(val)
                {
                    input.classList.remove('border-red');
                    tootlTip.classList.remove('showTooltip')
                    input.removeAttribute('validate')
                }else{
                    var nameToValidate = input.getAttribute('nameToValidate');
                    input.classList.add('border-red');
                    tootlTip.classList.add("showTooltip");
                    tootlTip.innerText = Resource[Common.LanguageCode].Validate.Required(nameToValidate);
                    input.setAttribute('validate' , false);
                }

                value = CommonFunction.formatMoney(value);
                this.product.Price = value;
            }catch (error) {
                console.log(error)
            }
        },

        'product.PromotionPrice' : function(val)
        {
            try{
                var value = CommonFunction.convertMoneyToNumber(val);
                var input = this.$refs.PromotionPrice;
                var tootlTip = input.parentElement.querySelector('.tooltiptext');
                if(val)
                {
                    input.classList.remove('border-red');
                    tootlTip.classList.remove('showTooltip')
                    input.removeAttribute('validate')
                }else{
                    var nameToValidate = input.getAttribute('nameToValidate');
                    input.classList.add('border-red');
                    tootlTip.classList.add("showTooltip");
                    tootlTip.innerText = Resource[Common.LanguageCode].Validate.Required(nameToValidate);
                    input.setAttribute('validate' , false);
                }

                value = CommonFunction.formatMoney(value);
                this.product.PromotionPrice = value;
            }catch (error) {
                console.log(error)
            }
        }
    }


}
</script>

<style>

</style>