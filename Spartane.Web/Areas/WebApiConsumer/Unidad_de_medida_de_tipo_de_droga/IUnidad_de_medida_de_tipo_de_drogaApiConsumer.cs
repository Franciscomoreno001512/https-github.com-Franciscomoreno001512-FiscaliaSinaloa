using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Unidad_de_medida_de_tipo_de_droga
{
    public interface IUnidad_de_medida_de_tipo_de_drogaApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga> GetByKey(short Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_drogaPagingModel> GetByKeyComplete(short Key);
        ApiResponse<bool> Delete(short Key, Spartane.Core.Domain.User.GlobalData Unidad_de_medida_de_tipo_de_drogaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Insert(Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga entity, Spartane.Core.Domain.User.GlobalData Unidad_de_medida_de_tipo_de_drogaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Update(Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga entity, Spartane.Core.Domain.User.GlobalData Unidad_de_medida_de_tipo_de_drogaInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_drogaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<short> GenerateID();
		ApiResponse<short> Update_Datos_Generales(Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

