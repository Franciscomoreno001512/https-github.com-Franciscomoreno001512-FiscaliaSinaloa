using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Redes_Sociales
{
    public interface IRedes_SocialesApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Redes_Sociales.Redes_Sociales>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Redes_Sociales.Redes_Sociales>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Redes_Sociales.Redes_Sociales> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Redes_Sociales.Redes_SocialesPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Redes_SocialesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Redes_Sociales.Redes_Sociales entity, Spartane.Core.Domain.User.GlobalData Redes_SocialesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Redes_Sociales.Redes_Sociales entity, Spartane.Core.Domain.User.GlobalData Redes_SocialesInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Redes_Sociales.Redes_Sociales>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Redes_Sociales.Redes_Sociales>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Redes_Sociales.Redes_Sociales>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Redes_Sociales.Redes_SocialesPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Redes_Sociales.Redes_Sociales>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Redes_Sociales.Redes_Sociales_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Redes_Sociales.Redes_Sociales_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

