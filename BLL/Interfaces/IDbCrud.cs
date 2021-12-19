using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IDbCrud

    {
        List<ProductModel> GetALLProduct();
        List<addStringModel> GetALLEnterString();
        ProductModel GetProduct(int idProduct);
        void CreateProduct(ProductModel p);
        void UpdateProduct(ProductModel p);
        void DeleteProduct(int idProduct);
        void CreateEnterString(addStringModel p);
        void DeleteEnterString(int idEnterString);
        List<TypeGoodsModel> GetALLTypeGoods();
        List<UserModel> GetALLUser();
    }
}
