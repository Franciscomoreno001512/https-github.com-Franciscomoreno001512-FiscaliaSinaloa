using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Discapacidades_Sensoriales
{
    public interface IDiscapacidades_SensorialesApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_SensorialesPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Discapacidades_SensorialesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales entity, Spartane.Core.Domain.User.GlobalData Discapacidades_SensorialesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales entity, Spartane.Core.Domain.User.GlobalData Discapacidades_SensorialesInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_SensorialesPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

