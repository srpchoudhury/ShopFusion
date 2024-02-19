using Microsoft.AspNetCore.Mvc;
using ShopFusion.Services.ProductAPI.Models.Dto;
using ShopFusion.Services.ProductAPI.Data;
using ShopFusion.Services.ProductAPI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;

namespace ShopFusion.Services.ProductAPI.Controllers
{
    [Route("api/product")]
    [ApiController]
    [EnableCors("AllowAll")]
    public class ProductAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;
        public ProductAPIController(AppDbContext db,IMapper mapper)
        {
            _db = db;
            _response = new ResponseDto();
            _mapper = mapper;
        }

        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
               // IEnumerable<Product> objList = _db.Products.ToList();
              //  _response.Result = _mapper.Map<IEnumerable<ProductDto>>(objList);

                var result = _db.Products.Join(_db.MainCategory, PD => PD.MainCategoryId, MC => MC.Id, (PD, MC) => new { PD, MC })
                                         .Join(_db.Brands, PD_MC => PD_MC.PD.BrandId, BD => BD.Id, (PD_MC, BD) => new { PD_MC, BD })
                                         .Join(_db.Categories, PD_MC_BD =>PD_MC_BD.PD_MC.PD.CategoryId, CG => CG.Id, (PD_MC_BD,CG) => new {PD_MC_BD, CG })
                                         .Join(_db.SubCategories,PD_MC_BD_CG =>PD_MC_BD_CG.PD_MC_BD.PD_MC.PD.SubCategoryId, SC =>SC.Id, (PD_MC_BD_CG,SC) => new { PD_MC_BD_CG, SC })
                                         .Where(x => x.SC.IsActive == true && 
                                                     x.PD_MC_BD_CG.PD_MC_BD.PD_MC.PD.IsActive == true &&
                                                     x.PD_MC_BD_CG.PD_MC_BD.BD.IsActive == true &&
                                                     x.PD_MC_BD_CG.PD_MC_BD.PD_MC.MC.IsActive == true &&
                                                     x.PD_MC_BD_CG.CG.IsActive == true )
                                         .Select(s => new 
                                         {
                                             ProductId = s.PD_MC_BD_CG.PD_MC_BD.PD_MC.PD.Id,
                                             ProductName = s.PD_MC_BD_CG.PD_MC_BD.PD_MC.PD.ProductName,
                                             ProductDescription = s.PD_MC_BD_CG.PD_MC_BD.PD_MC.PD.ProductDescription,
                                             ProductImage = s.PD_MC_BD_CG.PD_MC_BD.PD_MC.PD.ProductImage,
                                             ProductPrice = s.PD_MC_BD_CG.PD_MC_BD.PD_MC.PD.ProductPrice,
                                             BrandId = s.PD_MC_BD_CG.PD_MC_BD.PD_MC.PD.BrandId,
                                             BrandName = s.PD_MC_BD_CG.PD_MC_BD.BD.BrandName,
                                             MainCategoryId = s.PD_MC_BD_CG.PD_MC_BD.PD_MC.PD.MainCategoryId,
                                             MainCategoryName = s.PD_MC_BD_CG.PD_MC_BD.PD_MC.MC.MainCategoryName,
                                             CategoryId = s.PD_MC_BD_CG.PD_MC_BD.PD_MC.PD.CategoryId,
                                             CategoryName = s.PD_MC_BD_CG.CG.CategoryName,
                                             SubCategoryId = s.PD_MC_BD_CG.PD_MC_BD.PD_MC.PD.SubCategoryId,
                                             SubCategoryName = s.SC.SubCategoryName
                                         }).ToList();
                _response.Result = result;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto Get(int id)
        {
            try
            {
                Product obj = _db.Products.First(u => u.Id == id);
                _response.Result=_mapper.Map<ProductDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

      
        [HttpPost]
        public ResponseDto Post([FromBody] ProductDto productDto)
        {
            try
            {
                Product obj = _mapper.Map<Product>(productDto);
                _db.Products.Add(obj);
                _db.SaveChanges();
                _response.Result = _mapper.Map<ProductDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }


        [HttpPut]
        public ResponseDto put([FromBody] ProductDto productDto)
        {
            try
            {
                Product obj = _mapper.Map<Product>(productDto);
                _db.Products.Update(obj);
                _db.SaveChanges();
                _response.Result = _mapper.Map<ProductDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        public ResponseDto Delete(int id)
        {
            try
            {
                Product obj = _db.Products.First(u => u.Id == id);
                _db.Products.Remove(obj);
                _db.SaveChanges(); 
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        /* [HttpGet]
        public ResponseDto GetMainCategory()
        {
            try
            {
                var obj = _db.MainCategory.ToList();
                _response.Result = obj;
            }
            catch (Exception ex)
            {

                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

       [HttpGet]
       public ResponseDto GetBrand()
        {
            try
            {
                IEnumerable<Brands> objList = _db.Brands.ToList();
                _response.Result = _mapper.Map<IEnumerable<BrandDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
      [HttpGet]
       public ResponseDto GetCategory()
       {
           try
           {
               IEnumerable<Categories> objList = _db.Categories.ToList();
               _response.Result = _mapper.Map<IEnumerable<CategoryDto>>(objList);
           }
           catch (Exception ex)
           {
               _response.IsSuccess = false;
               _response.Message = ex.Message;
           }
           return _response;
       }
       [HttpGet]
       public ResponseDto GetSubCategory()
       {
           try
           {
               IEnumerable<SubCategories> objList = _db.SubCategories.ToList();
               _response.Result = _mapper.Map<IEnumerable<SubCategoryDto>>(objList);
           }
           catch (Exception ex)
           {
               _response.IsSuccess = false;
               _response.Message = ex.Message;
           }
           return _response;
       }*/
    }
}
