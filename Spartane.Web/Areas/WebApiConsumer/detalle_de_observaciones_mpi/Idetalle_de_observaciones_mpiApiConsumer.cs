using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.detalle_de_observaciones_mpi
{
    public interface Idetalle_de_observaciones_mpiApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpiPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData detalle_de_observaciones_mpiInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi entity, Spartane.Core.Domain.User.GlobalData detalle_de_observaciones_mpiInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi entity, Spartane.Core.Domain.User.GlobalData detalle_de_observaciones_mpiInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpiPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

