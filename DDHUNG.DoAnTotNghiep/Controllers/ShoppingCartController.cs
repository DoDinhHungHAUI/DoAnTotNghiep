using DDHUNG.ApplicationCore.Common;
using DDHUNG.ApplicationCore.Entity;
using DDHUNG.ApplicationCore.EtensionMethod;
using DDHUNG.ApplicationCore.Interface.Service;
using DDHUNG.ApplicationCore.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDHUNG.DoAnTotNghiep.Controllers
{
    public class ShoppingCartController : Controller
    {

        #region method
        private readonly IProductService _productService;
        private readonly IProductOrderService _productOrderService;
        #endregion

        #region Constructor

        public ShoppingCartController(IProductService productService, IProductOrderService productOrderService)
        {
            _productService = productService;
            _productOrderService = productOrderService;
        }

        #endregion


        public IActionResult Index()
        {

            var cartJson = HttpContext.Session.GetString(CommonConstant.SessionCart);

            if (cartJson == null)   
            {
                var newCart = new List<ShoppingCartViewModel>();
                string jsonCart = JsonConvert.SerializeObject(newCart);
                HttpContext.Session.SetString(CommonConstant.SessionCart, jsonCart);
            }

            return View();
        }


        /// <summary>
        /// Thêm sản phẩm vào giỏ hành
        /// </summary>
        /// <param name="productId">Id sản phẩm</param>
        /// <returns></returns>
        /// DDHung 24/07/2022

        [HttpPost]
        public JsonResult Add(Guid? productId)
        {
            var cartJson = HttpContext.Session.GetString(CommonConstant.SessionCart);

            var cartParseJson = new List<ShoppingCartViewModel>();

            if(cartJson != null)
            {
                cartParseJson = JsonConvert.DeserializeObject<List<ShoppingCartViewModel>>(cartJson);
            }    

            var product = _productService.GetProductById(productId).Result;

            if (product.Quantity == 0)
            {
                return Json(new
                {
                    status = false,
                    message = "Sản phẩm này hiện đang hết hàng"
                });
            }

            if (cartParseJson.Any(x => x.Product.ProductId == productId))
            {
                foreach (var item in cartParseJson)
                {
                    if (item.Product.ProductId == productId)
                    {
                        item.Quantity += 1;
                    }
                }
            }
            else
            {
                ShoppingCartViewModel newItem = new ShoppingCartViewModel();
                newItem.ProductId = (Guid)productId;

                newItem.Product = product;
                newItem.Quantity = 1;
                newItem.Amount = newItem.Quantity * newItem.Product.Price;
                cartParseJson.Add(newItem);
            }

            string jsonCart = JsonConvert.SerializeObject(cartParseJson);

            HttpContext.Session.SetString(CommonConstant.SessionCart, jsonCart);

            return Json(new
            {
                status = true,
                Counter = TinhTongSoLuong()
            });
        }


        /// <summary>
        /// Thêm sản phẩm vào giỏ hàng từ màn chi tiết sản phẩm
        /// </summary>
        /// <param name="productId">id sản phẩm</param>
        /// <param name="quantity">Số lượng</param>
        /// <returns></returns>
        /// DDHung 24/07/2022
        [HttpPost]
        public JsonResult AddCartProductDetail(Guid? productId, int? quantity)
        {
            var cartJson = HttpContext.Session.GetString(CommonConstant.SessionCart);

            var cartParseJson = new List<ShoppingCartViewModel>();

            if (cartJson != null)
            {
                cartParseJson = JsonConvert.DeserializeObject<List<ShoppingCartViewModel>>(cartJson);
            }

            var product = _productService.GetProductById(productId).Result;

            if (product.Quantity == 0)
            {
                return Json(new
                {
                    status = false,
                    message = "Sản phẩm này hiện đang hết hàng"
                });
            }

            if (cartParseJson.Any(x => x.Product.ProductId == productId))
            {
                foreach (var item in cartParseJson)
                {
                    if (item.Product.ProductId == productId)
                    {
                        item.Quantity += quantity;
                    }
                }
            }
            else
            {
                ShoppingCartViewModel newItem = new ShoppingCartViewModel();
                newItem.ProductId = (Guid)productId;

                newItem.Product = product;
                newItem.Quantity = quantity;
                newItem.Amount = newItem.Quantity * newItem.Product.Price;
                cartParseJson.Add(newItem);
            }

            string jsonCart = JsonConvert.SerializeObject(cartParseJson);

            HttpContext.Session.SetString(CommonConstant.SessionCart, jsonCart);

            return Json(new
            {
                status = true,
                Counter = TinhTongSoLuong()
            });
        }


        //Phương thức tính tổng Số lượng
        public int? TinhTongSoLuong()
        {
            //Lấy giỏ hàng

            var cartJson = HttpContext.Session.GetString(CommonConstant.SessionCart);

            var cartParseJson = new List<ShoppingCartViewModel>();

            if (cartJson != null)
            {
                cartParseJson = JsonConvert.DeserializeObject<List<ShoppingCartViewModel>>(cartJson);
            }

            //List<ShoppingCartViewModel> lstGioHang = (List<ShoppingCartViewModel>)Session[CommonConstants.SessionCart];
            if (cartParseJson.Count == 0)
            {
                return 0;
            }
            return cartParseJson.Sum(n => n.Quantity);
        }


        /// <summary>
        /// Cập nhật thông tin giỏ hàng
        /// </summary>
        /// <param name="cartData"></param>
        /// <returns></returns>
        /// DDHung
        [HttpPost]
        public JsonResult Update(string cartData)
        {
            var cartViewModel = JsonConvert.DeserializeObject<List<ShoppingCartViewModel>>(cartData);
  
            var cartJson = HttpContext.Session.GetString(CommonConstant.SessionCart);

            var cartParseJson = new List<ShoppingCartViewModel>();

            if (cartJson != null)
            {
                cartParseJson = JsonConvert.DeserializeObject<List<ShoppingCartViewModel>>(cartJson);
            }

            foreach (var item in cartParseJson)
            {
                foreach (var jitem in cartViewModel)
                {
                    if (item.ProductId == jitem.ProductId)
                    {
                        item.Quantity = jitem.Quantity;
                    }
                }
            }

            string jsonCart = JsonConvert.SerializeObject(cartParseJson);

            HttpContext.Session.SetString(CommonConstant.SessionCart, jsonCart);

            return Json(new
            {
                status = true,
                Counter = TinhTongSoLuong()
            });
        }


        /// <summary>
        /// Lấy sản phẩm trong giỏ hàng
        /// </summary>
        /// <returns></returns>
        /// DDHung 21/07/2022
        public JsonResult GetAll()
        {
            var cartJson = HttpContext.Session.GetString(CommonConstant.SessionCart);

            var cartParseJson = new List<ShoppingCartViewModel>();

            if (cartJson != null)
            {
                cartParseJson = JsonConvert.DeserializeObject<List<ShoppingCartViewModel>>(cartJson);
            }

            return Json(new
            {
                data = cartParseJson,
                status = true,
                Counter = TinhTongSoLuong()
            });
        }



        /// <summary>
        /// Xóa sản phẩm trong giỏ hàng
        /// </summary>
        /// <param name="productId">Id sản phẩm</param>
        /// <returns></returns>
        /// DDHung 21/07/2022
        [HttpPost]
        public JsonResult DeleteItem(Guid? productId)
        {

            var cartJson = HttpContext.Session.GetString(CommonConstant.SessionCart);

            var cartParseJson = new List<ShoppingCartViewModel>();

            if (cartJson != null)
            {
                cartParseJson = JsonConvert.DeserializeObject<List<ShoppingCartViewModel>>(cartJson);
            }

            if (cartParseJson != null && cartParseJson.Count > 0)
            {
                cartParseJson.RemoveAll(x => x.Product.ProductId == productId);

                string jsonCart = JsonConvert.SerializeObject(cartParseJson);

                HttpContext.Session.SetString(CommonConstant.SessionCart, jsonCart);

                return Json(new
                {
                    status = true,
                    Counter = TinhTongSoLuong()
                });
            }
            return Json(new
            {
                status = false
            });
        }

        /// <summary>
        /// Xác nhận đặt hàng
        /// </summary>
        /// <param name="orderViewModel"></param>
        /// <returns></returns>
        public JsonResult CreateOrder(string orderViewModel)
        {
            var order = JsonConvert.DeserializeObject<ProductOrderViewModel>(orderViewModel);

            var orderNew = new ProductOrder();

            orderNew.ProductOrderId = Guid.NewGuid();
            orderNew.UpdateOrder(order);


            var cartJson = HttpContext.Session.GetString(CommonConstant.SessionCart);

            var cartParseJson = new List<ShoppingCartViewModel>();

            if (cartJson != null)
            {
                cartParseJson = JsonConvert.DeserializeObject<List<ShoppingCartViewModel>>(cartJson);
            }


            List<ProductOrderDetail> orderDetails = new List<ProductOrderDetail>();
            bool isEnough = true;
            foreach (var item in cartParseJson)
            {
                var detail = new ProductOrderDetail();
                detail.ProductOrderDetailId = Guid.NewGuid();
                detail.ProductId = item.Product.ProductId;
                detail.ProductOrderId = orderNew.ProductOrderId;
                detail.Quantity = item.Quantity;
                detail.ProductPrice = item.Product.Price;
                detail.TotalPrice = (item.Quantity ?? 0) * (item.Product.Price ?? 0);
                orderDetails.Add(detail);

                isEnough = _productService.SellProduct(item.ProductId, item.Quantity).Result;

                if(isEnough == false)
                {
                    break;
                }    
            }

            if (isEnough)
            {
                var rowAffect =  _productOrderService.CreateOrderProduct(orderNew, orderDetails);
                return Json(new
                {
                    status = true
                });
            }
            else
            {
                return Json(new
                {
                    status = false,
                    message = "Không đủ hàng."
                });
            }
        }

        [HttpPost]
        public JsonResult DeleteAll()
        {

            var cartParseJson = new List<ShoppingCartViewModel>();

            string jsonCart = JsonConvert.SerializeObject(cartParseJson);

            HttpContext.Session.SetString(CommonConstant.SessionCart, jsonCart);

            return Json(new
            {
                status = true,
                Counter = TinhTongSoLuong()
            });
        }



    }
}
