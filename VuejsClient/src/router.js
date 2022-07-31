//Định nghĩa router đến các component

import ProductComponent from './components/ProductComponent.vue'
import UserComponent from './components/UserComponent.vue'
export const routes = [
    {path : '/' , name : "Danh sách sản phẩm" , component : ProductComponent},
    {path : '/products' , name : "Danh sách sản phẩm" , component : ProductComponent},
    {path : '/Users' , name : "Danh sách người dùng" , component : UserComponent}
]
