using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Lugar_del_Hallazgo
{
    public interface ILugar_del_HallazgoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_HallazgoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Lugar_del_HallazgoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo entity, Spartane.Core.Domain.User.GlobalData Lugar_del_HallazgoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo entity, Spartane.Core.Domain.User.GlobalData Lugar_del_HallazgoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_HallazgoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

