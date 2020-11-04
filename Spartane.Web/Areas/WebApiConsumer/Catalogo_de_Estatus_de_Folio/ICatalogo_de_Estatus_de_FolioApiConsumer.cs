using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Catalogo_de_Estatus_de_Folio
{
    public interface ICatalogo_de_Estatus_de_FolioApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_FolioPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Catalogo_de_Estatus_de_FolioInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio entity, Spartane.Core.Domain.User.GlobalData Catalogo_de_Estatus_de_FolioInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio entity, Spartane.Core.Domain.User.GlobalData Catalogo_de_Estatus_de_FolioInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_FolioPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

