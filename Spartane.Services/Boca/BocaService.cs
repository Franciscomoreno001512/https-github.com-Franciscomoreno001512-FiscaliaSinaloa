using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Boca;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Boca
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class BocaService : IBocaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Boca.Boca> _BocaRepository;
        #endregion

        #region Ctor
        public BocaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Boca.Boca> BocaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._BocaRepository = BocaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Boca.Boca> SelAll(bool ConRelaciones)
        {
            return this._BocaRepository.Table.ToList();
        }

        public IList<Core.Domain.Boca.Boca> SelAllComplete(bool ConRelaciones)
        {
            return this._BocaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Boca.Boca> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._BocaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Boca.Boca> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._BocaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Boca.Boca> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._BocaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Boca.BocaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            BocaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Boca.Boca> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._BocaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Boca.Boca GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Boca.Boca result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData BocaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Boca.Boca entity, Spartane.Core.Domain.User.GlobalData BocaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Boca.Boca entity, Spartane.Core.Domain.User.GlobalData BocaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

