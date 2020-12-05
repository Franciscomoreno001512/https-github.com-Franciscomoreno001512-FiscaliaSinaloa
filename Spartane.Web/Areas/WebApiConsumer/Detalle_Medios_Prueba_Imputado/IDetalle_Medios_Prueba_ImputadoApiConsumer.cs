using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_Medios_Prueba_Imputado
{
    public interface IDetalle_Medios_Prueba_ImputadoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_ImputadoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Medios_Prueba_ImputadoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado entity, Spartane.Core.Domain.User.GlobalData Detalle_Medios_Prueba_ImputadoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado entity, Spartane.Core.Domain.User.GlobalData Detalle_Medios_Prueba_ImputadoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_ImputadoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

