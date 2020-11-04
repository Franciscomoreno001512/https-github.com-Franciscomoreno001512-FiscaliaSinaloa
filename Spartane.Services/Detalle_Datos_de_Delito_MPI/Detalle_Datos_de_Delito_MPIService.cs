using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Datos_de_Delito_MPI
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Datos_de_Delito_MPIService : IDetalle_Datos_de_Delito_MPIService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI> _Detalle_Datos_de_Delito_MPIRepository;
        #endregion

        #region Ctor
        public Detalle_Datos_de_Delito_MPIService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI> Detalle_Datos_de_Delito_MPIRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Datos_de_Delito_MPIRepository = Detalle_Datos_de_Delito_MPIRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Datos_de_Delito_MPIRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Datos_de_Delito_MPIRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Datos_de_Delito_MPIRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Datos_de_Delito_MPIRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Datos_de_Delito_MPIRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPIPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Datos_de_Delito_MPIPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Datos_de_Delito_MPIRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Datos_de_Delito_MPIInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI entity, Spartane.Core.Domain.User.GlobalData Detalle_Datos_de_Delito_MPIInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI entity, Spartane.Core.Domain.User.GlobalData Detalle_Datos_de_Delito_MPIInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

