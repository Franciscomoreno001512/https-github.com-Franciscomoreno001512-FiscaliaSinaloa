using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Datos_Personales_Adicionales_Solicitante_MASC
{
    public interface IDatos_Personales_Adicionales_Solicitante_MASCApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Datos_Personales_Adicionales_Solicitante_MASC.Datos_Personales_Adicionales_Solicitante_MASC>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Datos_Personales_Adicionales_Solicitante_MASC.Datos_Personales_Adicionales_Solicitante_MASC>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Datos_Personales_Adicionales_Solicitante_MASC.Datos_Personales_Adicionales_Solicitante_MASC> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Datos_Personales_Adicionales_Solicitante_MASC.Datos_Personales_Adicionales_Solicitante_MASCPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Datos_Personales_Adicionales_Solicitante_MASCInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Datos_Personales_Adicionales_Solicitante_MASC.Datos_Personales_Adicionales_Solicitante_MASC entity, Spartane.Core.Domain.User.GlobalData Datos_Personales_Adicionales_Solicitante_MASCInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Datos_Personales_Adicionales_Solicitante_MASC.Datos_Personales_Adicionales_Solicitante_MASC entity, Spartane.Core.Domain.User.GlobalData Datos_Personales_Adicionales_Solicitante_MASCInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Datos_Personales_Adicionales_Solicitante_MASC.Datos_Personales_Adicionales_Solicitante_MASC>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Datos_Personales_Adicionales_Solicitante_MASC.Datos_Personales_Adicionales_Solicitante_MASC>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Datos_Personales_Adicionales_Solicitante_MASC.Datos_Personales_Adicionales_Solicitante_MASC>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Datos_Personales_Adicionales_Solicitante_MASC.Datos_Personales_Adicionales_Solicitante_MASCPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Datos_Personales_Adicionales_Solicitante_MASC.Datos_Personales_Adicionales_Solicitante_MASC>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Datos_Personales_Adicionales_Solicitante_MASC.Datos_Personales_Adicionales_Solicitante_MASC_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Datos_Personales_Adicionales_Solicitante_MASC.Datos_Personales_Adicionales_Solicitante_MASC_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

