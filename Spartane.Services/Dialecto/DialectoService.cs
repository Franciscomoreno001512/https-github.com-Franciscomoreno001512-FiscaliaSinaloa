using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Dialecto;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Dialecto
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class DialectoService : IDialectoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Dialecto.Dialecto> _DialectoRepository;
        #endregion

        #region Ctor
        public DialectoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Dialecto.Dialecto> DialectoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._DialectoRepository = DialectoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Dialecto.Dialecto> SelAll(bool ConRelaciones)
        {
            return this._DialectoRepository.Table.ToList();
        }

        public IList<Core.Domain.Dialecto.Dialecto> SelAllComplete(bool ConRelaciones)
        {
            return this._DialectoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Dialecto.Dialecto> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._DialectoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Dialecto.Dialecto> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._DialectoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Dialecto.Dialecto> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._DialectoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Dialecto.DialectoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            DialectoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Dialecto.Dialecto> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._DialectoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Dialecto.Dialecto GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Dialecto.Dialecto result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData DialectoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Dialecto.Dialecto entity, Spartane.Core.Domain.User.GlobalData DialectoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Dialecto.Dialecto entity, Spartane.Core.Domain.User.GlobalData DialectoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

