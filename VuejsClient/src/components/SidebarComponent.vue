<template>
    <div class="scroll-sidebar">
        <!-- Sidebar navigation-->
        <nav class="sidebar-nav">
            <ul id="sidebarnav">
                <li class="sidebar-item">
                    <!-- <a class="sidebar-link waves-effect waves-dark sidebar-link" href="index.html"
                        aria-expanded="false">
                        <i class="mdi mdi-av-timer"></i>
                        <span class="hide-menu">Danh sách sản phẩm</span>
                    </a> -->
                    <router-link class="sidebar-link waves-effect waves-dark sidebar-link"  aria-expanded="false" to="/products">
                        <i class="mdi mdi-av-timer"></i>
                        <span class="hide-menu">Danh sách sản phẩm</span>
                    </router-link>
                </li>
                <li class="sidebar-item">
                    <!-- <a class="sidebar-link waves-effect waves-dark sidebar-link" href="pages-profile.html" aria-expanded="false">
                        <i class="mdi mdi-account-network"></i>
                        <span class="hide-menu">Danh sách người dùng</span>
                    </a> -->

                    <router-link class="sidebar-link waves-effect waves-dark sidebar-link" aria-expanded="false" to="/Users">
                        <i class="mdi mdi-account-network"></i>
                        <span class="hide-menu">Danh sách người dùng</span>
                    </router-link>
                </li>
                <li class="sidebar-item">
                    <a class="sidebar-link waves-effect waves-dark sidebar-link" href="form-basic.html"
                        aria-expanded="false">
                        <i class="mdi mdi-arrange-bring-forward"></i>
                        <span class="hide-menu">Đơn hàng</span>
                    </a>
                </li>
                <li class="sidebar-item">
                    <a class="sidebar-link waves-effect waves-dark sidebar-link" href="table-basic.html"
                        aria-expanded="false">
                        <i class="mdi mdi-border-none"></i>
                        <span class="hide-menu">Table</span>
                    </a>
                </li>
                <li class="sidebar-item">
                    <a class="sidebar-link waves-effect waves-dark sidebar-link" href="icon-material.html"
                        aria-expanded="false">
                        <i class="mdi mdi-face"></i>
                        <span class="hide-menu">Icon</span>
                    </a>
                </li>
                <li class="sidebar-item">
                    <a class="sidebar-link waves-effect waves-dark sidebar-link" href="starter-kit.html"
                        aria-expanded="false">
                        <i class="mdi mdi-file"></i>
                        <span class="hide-menu">Blank</span>
                    </a>
                </li>
                <li class="sidebar-item">
                    <a class="sidebar-link waves-effect waves-dark sidebar-link" href="error-404.html"
                        aria-expanded="false">
                        <i class="mdi mdi-alert-outline"></i>
                        <span class="hide-menu">404</span>
                    </a>
                </li>
            </ul>
        </nav>
        <!-- End Sidebar navigation -->
    </div>
</template>

<script>


export default {
  name: 'sidebar-component',
  components: {
    
  },
  data(){
    return{
       
    }
  },
 
}
</script>
