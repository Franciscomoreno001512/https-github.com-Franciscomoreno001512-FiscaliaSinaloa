using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Historial_Estatus_Modulo_Servicio_Pericial
{
    public interface IHistorial_Estatus_Modulo_Servicio_PericialApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Historial_Estatus_Modulo_Servicio_Pericial.Historial_Estatus_Modulo_Servicio_Pericial>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Historial_Estatus_Modulo_Servicio_Pericial.Historial_Estatus_Modulo_Servicio_Pericial>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Historial_Estatus_Modulo_Servicio_Pericial.Historial_Estatus_Modulo_Servicio_Pericial> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Historial_Estatus_Modulo_Servicio_Pericial.Historial_Estatus_Modulo_Servicio_PericialPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Historial_Estatus_Modulo_Servicio_PericialInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Historial_Estatus_Modulo_Servicio_Pericial.Historial_Estatus_Modulo_Servicio_Pericial entity, Spartane.Core.Domain.User.GlobalData Historial_Estatus_Modulo_Servicio_PericialInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Historial_Estatus_Modulo_Servicio_Pericial.Historial_Estatus_Modulo_Servicio_Pericial entity, Spartane.Core.Domain.User.GlobalData Historial_Estatus_Modulo_Servicio_PericialInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Historial_Estatus_Modulo_Servicio_Pericial.Historial_Estatus_Modulo_Servicio_Pericial>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Historial_Estatus_Modulo_Servicio_Pericial.Historial_Estatus_Modulo_Servicio_Pericial>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Historial_Estatus_Modulo_Servicio_Pericial.Historial_Estatus_Modulo_Servicio_Pericial>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Historial_Estatus_Modulo_Servicio_Pericial.Historial_Estatus_Modulo_Servicio_PericialPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Historial_Estatus_Modulo_Servicio_Pericial.Historial_Estatus_Modulo_Servicio_Pericial>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Historial_Estatus_Modulo_Servicio_Pericial.Historial_Estatus_Modulo_Servicio_Pericial_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Historial_Estatus_Modulo_Servicio_Pericial.Historial_Estatus_Modulo_Servicio_Pericial_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

