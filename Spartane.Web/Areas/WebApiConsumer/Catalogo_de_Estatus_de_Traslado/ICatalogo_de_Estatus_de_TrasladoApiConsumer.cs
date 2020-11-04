using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Catalogo_de_Estatus_de_Traslado
{
    public interface ICatalogo_de_Estatus_de_TrasladoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_TrasladoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Catalogo_de_Estatus_de_TrasladoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado entity, Spartane.Core.Domain.User.GlobalData Catalogo_de_Estatus_de_TrasladoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado entity, Spartane.Core.Domain.User.GlobalData Catalogo_de_Estatus_de_TrasladoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_TrasladoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

