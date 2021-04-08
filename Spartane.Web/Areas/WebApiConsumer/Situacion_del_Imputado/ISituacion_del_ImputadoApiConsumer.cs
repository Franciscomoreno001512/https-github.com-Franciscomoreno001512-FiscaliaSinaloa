using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Situacion_del_Imputado
{
    public interface ISituacion_del_ImputadoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_ImputadoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Situacion_del_ImputadoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado entity, Spartane.Core.Domain.User.GlobalData Situacion_del_ImputadoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado entity, Spartane.Core.Domain.User.GlobalData Situacion_del_ImputadoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_ImputadoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

