using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Tipo_de_medios_de_transporte
{
    public interface ITipo_de_medios_de_transporteApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte> GetByKey(short Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transportePagingModel> GetByKeyComplete(short Key);
        ApiResponse<bool> Delete(short Key, Spartane.Core.Domain.User.GlobalData Tipo_de_medios_de_transporteInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Insert(Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte entity, Spartane.Core.Domain.User.GlobalData Tipo_de_medios_de_transporteInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Update(Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte entity, Spartane.Core.Domain.User.GlobalData Tipo_de_medios_de_transporteInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transportePagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<short> GenerateID();
		ApiResponse<short> Update_Datos_Generales(Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

