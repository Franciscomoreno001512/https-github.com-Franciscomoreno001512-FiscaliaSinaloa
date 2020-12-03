using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.detalle_de_observaciones_mpi;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.detalle_de_observaciones_mpi
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class detalle_de_observaciones_mpiService : Idetalle_de_observaciones_mpiService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi> _detalle_de_observaciones_mpiRepository;
        #endregion

        #region Ctor
        public detalle_de_observaciones_mpiService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi> detalle_de_observaciones_mpiRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._detalle_de_observaciones_mpiRepository = detalle_de_observaciones_mpiRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi> SelAll(bool ConRelaciones)
        {
            return this._detalle_de_observaciones_mpiRepository.Table.ToList();
        }

        public IList<Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi> SelAllComplete(bool ConRelaciones)
        {
            return this._detalle_de_observaciones_mpiRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._detalle_de_observaciones_mpiRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._detalle_de_observaciones_mpiRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._detalle_de_observaciones_mpiRepository.Table.ToList();
        }

        public Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpiPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            detalle_de_observaciones_mpiPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._detalle_de_observaciones_mpiRepository.Table.ToList();
        }

        public Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData detalle_de_observaciones_mpiInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi entity, Spartane.Core.Domain.User.GlobalData detalle_de_observaciones_mpiInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi entity, Spartane.Core.Domain.User.GlobalData detalle_de_observaciones_mpiInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

