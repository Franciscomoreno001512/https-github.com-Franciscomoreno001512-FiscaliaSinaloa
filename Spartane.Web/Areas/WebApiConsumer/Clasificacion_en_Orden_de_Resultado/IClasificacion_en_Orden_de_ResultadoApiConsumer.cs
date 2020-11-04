using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Clasificacion_en_Orden_de_Resultado
{
    public interface IClasificacion_en_Orden_de_ResultadoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_ResultadoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Clasificacion_en_Orden_de_ResultadoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado entity, Spartane.Core.Domain.User.GlobalData Clasificacion_en_Orden_de_ResultadoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado entity, Spartane.Core.Domain.User.GlobalData Clasificacion_en_Orden_de_ResultadoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_ResultadoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

