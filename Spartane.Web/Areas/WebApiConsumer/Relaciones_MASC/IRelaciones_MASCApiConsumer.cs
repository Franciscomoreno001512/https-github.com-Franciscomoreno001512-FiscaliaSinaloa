using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Relaciones_MASC
{
    public interface IRelaciones_MASCApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASCPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Relaciones_MASCInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC entity, Spartane.Core.Domain.User.GlobalData Relaciones_MASCInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC entity, Spartane.Core.Domain.User.GlobalData Relaciones_MASCInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASCPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Resolucion_de_Solicitud(Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC_Resolucion_de_Solicitud entity);
		ApiResponse<Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC_Resolucion_de_Solicitud> Get_Resolucion_de_Solicitud(string Key);

		ApiResponse<int> Update_Resolucion_de_Procedimiento(Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC_Resolucion_de_Procedimiento entity);
		ApiResponse<Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC_Resolucion_de_Procedimiento> Get_Resolucion_de_Procedimiento(string Key);


    }
}

