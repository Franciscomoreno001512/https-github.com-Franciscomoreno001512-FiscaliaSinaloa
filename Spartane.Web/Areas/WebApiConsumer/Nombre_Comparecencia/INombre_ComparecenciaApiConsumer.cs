using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Nombre_Comparecencia
{
    public interface INombre_ComparecenciaApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_ComparecenciaPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Nombre_ComparecenciaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia entity, Spartane.Core.Domain.User.GlobalData Nombre_ComparecenciaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia entity, Spartane.Core.Domain.User.GlobalData Nombre_ComparecenciaInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_ComparecenciaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

