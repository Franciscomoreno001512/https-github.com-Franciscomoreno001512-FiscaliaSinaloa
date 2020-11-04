using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Catalogo_Unidad_Policial
{
    public interface ICatalogo_Unidad_PolicialApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Unidad_Policial.Catalogo_Unidad_Policial>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Unidad_Policial.Catalogo_Unidad_Policial>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Catalogo_Unidad_Policial.Catalogo_Unidad_Policial> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Catalogo_Unidad_Policial.Catalogo_Unidad_PolicialPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Catalogo_Unidad_PolicialInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Catalogo_Unidad_Policial.Catalogo_Unidad_Policial entity, Spartane.Core.Domain.User.GlobalData Catalogo_Unidad_PolicialInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Catalogo_Unidad_Policial.Catalogo_Unidad_Policial entity, Spartane.Core.Domain.User.GlobalData Catalogo_Unidad_PolicialInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Unidad_Policial.Catalogo_Unidad_Policial>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Unidad_Policial.Catalogo_Unidad_Policial>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Unidad_Policial.Catalogo_Unidad_Policial>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Catalogo_Unidad_Policial.Catalogo_Unidad_PolicialPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Unidad_Policial.Catalogo_Unidad_Policial>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Catalogo_Unidad_Policial.Catalogo_Unidad_Policial_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Catalogo_Unidad_Policial.Catalogo_Unidad_Policial_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

