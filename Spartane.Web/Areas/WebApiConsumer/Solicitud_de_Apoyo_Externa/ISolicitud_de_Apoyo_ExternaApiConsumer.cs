using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Solicitud_de_Apoyo_Externa
{
    public interface ISolicitud_de_Apoyo_ExternaApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_ExternaPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Solicitud_de_Apoyo_ExternaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa entity, Spartane.Core.Domain.User.GlobalData Solicitud_de_Apoyo_ExternaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa entity, Spartane.Core.Domain.User.GlobalData Solicitud_de_Apoyo_ExternaInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_ExternaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Contestacion(Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa_Contestacion entity);
		ApiResponse<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa_Contestacion> Get_Contestacion(string Key);


    }
}

