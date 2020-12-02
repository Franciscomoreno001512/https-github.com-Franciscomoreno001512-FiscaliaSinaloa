using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Color_de_medio_de_trasporte
{
    public interface IColor_de_medio_de_trasporteApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte> GetByKey(short Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasportePagingModel> GetByKeyComplete(short Key);
        ApiResponse<bool> Delete(short Key, Spartane.Core.Domain.User.GlobalData Color_de_medio_de_trasporteInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Insert(Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte entity, Spartane.Core.Domain.User.GlobalData Color_de_medio_de_trasporteInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Update(Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte entity, Spartane.Core.Domain.User.GlobalData Color_de_medio_de_trasporteInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasportePagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<short> GenerateID();
		ApiResponse<short> Update_Datos_Generales(Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

