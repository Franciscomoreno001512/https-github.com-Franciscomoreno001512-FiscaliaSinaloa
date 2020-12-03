using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Electronicos_y_Multimedia
{
    public interface IDetalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Aseguramiento_Electronicos_y_Multimedia.Detalle_Aseguramiento_Electronicos_y_Multimedia>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Aseguramiento_Electronicos_y_Multimedia.Detalle_Aseguramiento_Electronicos_y_Multimedia>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_Aseguramiento_Electronicos_y_Multimedia.Detalle_Aseguramiento_Electronicos_y_Multimedia> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_Aseguramiento_Electronicos_y_Multimedia.Detalle_Aseguramiento_Electronicos_y_MultimediaPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Aseguramiento_Electronicos_y_MultimediaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Detalle_Aseguramiento_Electronicos_y_Multimedia.Detalle_Aseguramiento_Electronicos_y_Multimedia entity, Spartane.Core.Domain.User.GlobalData Detalle_Aseguramiento_Electronicos_y_MultimediaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Detalle_Aseguramiento_Electronicos_y_Multimedia.Detalle_Aseguramiento_Electronicos_y_Multimedia entity, Spartane.Core.Domain.User.GlobalData Detalle_Aseguramiento_Electronicos_y_MultimediaInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_Aseguramiento_Electronicos_y_Multimedia.Detalle_Aseguramiento_Electronicos_y_Multimedia>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Aseguramiento_Electronicos_y_Multimedia.Detalle_Aseguramiento_Electronicos_y_Multimedia>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Aseguramiento_Electronicos_y_Multimedia.Detalle_Aseguramiento_Electronicos_y_Multimedia>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_Aseguramiento_Electronicos_y_Multimedia.Detalle_Aseguramiento_Electronicos_y_MultimediaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Aseguramiento_Electronicos_y_Multimedia.Detalle_Aseguramiento_Electronicos_y_Multimedia>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Detalle_Aseguramiento_Electronicos_y_Multimedia.Detalle_Aseguramiento_Electronicos_y_Multimedia_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_Aseguramiento_Electronicos_y_Multimedia.Detalle_Aseguramiento_Electronicos_y_Multimedia_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

