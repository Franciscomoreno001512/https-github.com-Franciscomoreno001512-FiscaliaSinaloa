using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Audiencia_de_Control_Reiteracion
{
    public interface IAudiencia_de_Control_ReiteracionApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_ReiteracionPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Audiencia_de_Control_ReiteracionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion entity, Spartane.Core.Domain.User.GlobalData Audiencia_de_Control_ReiteracionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion entity, Spartane.Core.Domain.User.GlobalData Audiencia_de_Control_ReiteracionInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_ReiteracionPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

