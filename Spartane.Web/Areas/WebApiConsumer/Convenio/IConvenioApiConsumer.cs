using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Convenio
{
    public interface IConvenioApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Convenio.Convenio>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Convenio.Convenio>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Convenio.Convenio> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Convenio.ConvenioPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData ConvenioInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Convenio.Convenio entity, Spartane.Core.Domain.User.GlobalData ConvenioInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Convenio.Convenio entity, Spartane.Core.Domain.User.GlobalData ConvenioInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Convenio.Convenio>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Convenio.Convenio>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Convenio.Convenio>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Convenio.ConvenioPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Convenio.Convenio>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Convenio.Convenio_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Convenio.Convenio_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

