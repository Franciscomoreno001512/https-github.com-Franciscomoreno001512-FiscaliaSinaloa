using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Ambito;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Ambito
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class AmbitoService : IAmbitoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Ambito.Ambito> _AmbitoRepository;
        #endregion

        #region Ctor
        public AmbitoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Ambito.Ambito> AmbitoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._AmbitoRepository = AmbitoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Ambito.Ambito> SelAll(bool ConRelaciones)
        {
            return this._AmbitoRepository.Table.ToList();
        }

        public IList<Core.Domain.Ambito.Ambito> SelAllComplete(bool ConRelaciones)
        {
            return this._AmbitoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Ambito.Ambito> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._AmbitoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Ambito.Ambito> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._AmbitoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Ambito.Ambito> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._AmbitoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Ambito.AmbitoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            AmbitoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Ambito.Ambito> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._AmbitoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Ambito.Ambito GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Ambito.Ambito result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData AmbitoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Ambito.Ambito entity, Spartane.Core.Domain.User.GlobalData AmbitoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Ambito.Ambito entity, Spartane.Core.Domain.User.GlobalData AmbitoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

