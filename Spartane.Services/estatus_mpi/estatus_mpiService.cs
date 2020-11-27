using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.estatus_mpi;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.estatus_mpi
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class estatus_mpiService : Iestatus_mpiService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.estatus_mpi.estatus_mpi> _estatus_mpiRepository;
        #endregion

        #region Ctor
        public estatus_mpiService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.estatus_mpi.estatus_mpi> estatus_mpiRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._estatus_mpiRepository = estatus_mpiRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.estatus_mpi.estatus_mpi> SelAll(bool ConRelaciones)
        {
            return this._estatus_mpiRepository.Table.ToList();
        }

        public IList<Core.Domain.estatus_mpi.estatus_mpi> SelAllComplete(bool ConRelaciones)
        {
            return this._estatus_mpiRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.estatus_mpi.estatus_mpi> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._estatus_mpiRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.estatus_mpi.estatus_mpi> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._estatus_mpiRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.estatus_mpi.estatus_mpi> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._estatus_mpiRepository.Table.ToList();
        }

        public Spartane.Core.Domain.estatus_mpi.estatus_mpiPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            estatus_mpiPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.estatus_mpi.estatus_mpi> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._estatus_mpiRepository.Table.ToList();
        }

        public Spartane.Core.Domain.estatus_mpi.estatus_mpi GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.estatus_mpi.estatus_mpi result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData estatus_mpiInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.estatus_mpi.estatus_mpi entity, Spartane.Core.Domain.User.GlobalData estatus_mpiInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.estatus_mpi.estatus_mpi entity, Spartane.Core.Domain.User.GlobalData estatus_mpiInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

