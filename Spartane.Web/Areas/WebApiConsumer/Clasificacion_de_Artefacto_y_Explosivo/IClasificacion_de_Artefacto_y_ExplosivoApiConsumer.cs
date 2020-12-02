using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Clasificacion_de_Artefacto_y_Explosivo
{
    public interface IClasificacion_de_Artefacto_y_ExplosivoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo> GetByKey(short Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_ExplosivoPagingModel> GetByKeyComplete(short Key);
        ApiResponse<bool> Delete(short Key, Spartane.Core.Domain.User.GlobalData Clasificacion_de_Artefacto_y_ExplosivoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Insert(Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo entity, Spartane.Core.Domain.User.GlobalData Clasificacion_de_Artefacto_y_ExplosivoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Update(Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo entity, Spartane.Core.Domain.User.GlobalData Clasificacion_de_Artefacto_y_ExplosivoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_ExplosivoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<short> GenerateID();
		ApiResponse<short> Update_Datos_Generales(Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

