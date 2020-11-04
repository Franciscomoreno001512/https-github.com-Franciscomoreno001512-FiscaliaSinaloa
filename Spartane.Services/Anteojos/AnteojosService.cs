using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Anteojos;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Anteojos
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class AnteojosService : IAnteojosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Anteojos.Anteojos> _AnteojosRepository;
        #endregion

        #region Ctor
        public AnteojosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Anteojos.Anteojos> AnteojosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._AnteojosRepository = AnteojosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Anteojos.Anteojos> SelAll(bool ConRelaciones)
        {
            return this._AnteojosRepository.Table.ToList();
        }

        public IList<Core.Domain.Anteojos.Anteojos> SelAllComplete(bool ConRelaciones)
        {
            return this._AnteojosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Anteojos.Anteojos> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._AnteojosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Anteojos.Anteojos> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._AnteojosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Anteojos.Anteojos> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._AnteojosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Anteojos.AnteojosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            AnteojosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Anteojos.Anteojos> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._AnteojosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Anteojos.Anteojos GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Anteojos.Anteojos result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData AnteojosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Anteojos.Anteojos entity, Spartane.Core.Domain.User.GlobalData AnteojosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Anteojos.Anteojos entity, Spartane.Core.Domain.User.GlobalData AnteojosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

