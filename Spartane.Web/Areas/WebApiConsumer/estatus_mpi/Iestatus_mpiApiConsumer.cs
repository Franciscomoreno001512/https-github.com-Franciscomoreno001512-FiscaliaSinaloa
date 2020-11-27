using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.estatus_mpi
{
    public interface Iestatus_mpiApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.estatus_mpi.estatus_mpi>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.estatus_mpi.estatus_mpi>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.estatus_mpi.estatus_mpi> GetByKey(short Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.estatus_mpi.estatus_mpiPagingModel> GetByKeyComplete(short Key);
        ApiResponse<bool> Delete(short Key, Spartane.Core.Domain.User.GlobalData estatus_mpiInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Insert(Spartane.Core.Domain.estatus_mpi.estatus_mpi entity, Spartane.Core.Domain.User.GlobalData estatus_mpiInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Update(Spartane.Core.Domain.estatus_mpi.estatus_mpi entity, Spartane.Core.Domain.User.GlobalData estatus_mpiInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.estatus_mpi.estatus_mpi>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.estatus_mpi.estatus_mpi>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.estatus_mpi.estatus_mpi>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.estatus_mpi.estatus_mpiPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.estatus_mpi.estatus_mpi>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<short> GenerateID();
		ApiResponse<short> Update_Datos_Generales(Spartane.Core.Domain.estatus_mpi.estatus_mpi_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.estatus_mpi.estatus_mpi_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

