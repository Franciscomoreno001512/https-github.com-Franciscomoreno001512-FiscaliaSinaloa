using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Indicios
{
    public interface IIndiciosApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Indicios.Indicios>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Indicios.Indicios>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Indicios.Indicios> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Indicios.IndiciosPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData IndiciosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Indicios.Indicios entity, Spartane.Core.Domain.User.GlobalData IndiciosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Indicios.Indicios entity, Spartane.Core.Domain.User.GlobalData IndiciosInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Indicios.Indicios>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Indicios.Indicios>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Indicios.Indicios>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Indicios.IndiciosPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Indicios.Indicios>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Registro_de_Indicios(Spartane.Core.Domain.Indicios.Indicios_Registro_de_Indicios entity);
		ApiResponse<Spartane.Core.Domain.Indicios.Indicios_Registro_de_Indicios> Get_Registro_de_Indicios(string Key);

		ApiResponse<int> Update_Datos_Indicios(Spartane.Core.Domain.Indicios.Indicios_Datos_Indicios entity);
		ApiResponse<Spartane.Core.Domain.Indicios.Indicios_Datos_Indicios> Get_Datos_Indicios(string Key);

		ApiResponse<int> Update_Solicitud_de_Indicios(Spartane.Core.Domain.Indicios.Indicios_Solicitud_de_Indicios entity);
		ApiResponse<Spartane.Core.Domain.Indicios.Indicios_Solicitud_de_Indicios> Get_Solicitud_de_Indicios(string Key);

		ApiResponse<int> Update_Devolucion_de_Indicios(Spartane.Core.Domain.Indicios.Indicios_Devolucion_de_Indicios entity);
		ApiResponse<Spartane.Core.Domain.Indicios.Indicios_Devolucion_de_Indicios> Get_Devolucion_de_Indicios(string Key);


    }
}

