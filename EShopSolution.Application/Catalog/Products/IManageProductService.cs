using EShopSolution.Data.Entities;
using EShopSolution.ViewModels.Catalog.Products;
using EShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task AddViewCout(int productId);

        Task<bool> UpdateStock(int productId, int addedQuantiy);

        Task<ProductViewModel> GetById(int productId, string languageId);
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManagetProductPagingRequest request);

        Task<int> AddImages(int productId, List<IFormFile> files);
        Task<int> UpdateImages(int productId, List<IFormFile> files);
        Task<int> RemoveImages(int productId, List<IFormFile> files);

        Task<List<ProductImageViewModel>> GetListImage(int productId);
    }
}
