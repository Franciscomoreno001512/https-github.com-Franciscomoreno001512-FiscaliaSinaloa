using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Contestacion_de_Portal_Ciudadano
{
    public interface IContestacion_de_Portal_CiudadanoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_CiudadanoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Contestacion_de_Portal_CiudadanoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano entity, Spartane.Core.Domain.User.GlobalData Contestacion_de_Portal_CiudadanoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano entity, Spartane.Core.Domain.User.GlobalData Contestacion_de_Portal_CiudadanoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_CiudadanoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

