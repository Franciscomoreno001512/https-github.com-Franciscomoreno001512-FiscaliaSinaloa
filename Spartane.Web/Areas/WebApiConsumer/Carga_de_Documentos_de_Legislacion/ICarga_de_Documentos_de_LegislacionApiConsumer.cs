using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Carga_de_Documentos_de_Legislacion
{
    public interface ICarga_de_Documentos_de_LegislacionApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Carga_de_Documentos_de_Legislacion.Carga_de_Documentos_de_Legislacion>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Carga_de_Documentos_de_Legislacion.Carga_de_Documentos_de_Legislacion>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Carga_de_Documentos_de_Legislacion.Carga_de_Documentos_de_Legislacion> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Carga_de_Documentos_de_Legislacion.Carga_de_Documentos_de_LegislacionPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Carga_de_Documentos_de_LegislacionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Carga_de_Documentos_de_Legislacion.Carga_de_Documentos_de_Legislacion entity, Spartane.Core.Domain.User.GlobalData Carga_de_Documentos_de_LegislacionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Carga_de_Documentos_de_Legislacion.Carga_de_Documentos_de_Legislacion entity, Spartane.Core.Domain.User.GlobalData Carga_de_Documentos_de_LegislacionInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Carga_de_Documentos_de_Legislacion.Carga_de_Documentos_de_Legislacion>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Carga_de_Documentos_de_Legislacion.Carga_de_Documentos_de_Legislacion>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Carga_de_Documentos_de_Legislacion.Carga_de_Documentos_de_Legislacion>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Carga_de_Documentos_de_Legislacion.Carga_de_Documentos_de_LegislacionPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Carga_de_Documentos_de_Legislacion.Carga_de_Documentos_de_Legislacion>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Carga_de_Documentos_de_Legislacion.Carga_de_Documentos_de_Legislacion_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Carga_de_Documentos_de_Legislacion.Carga_de_Documentos_de_Legislacion_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

