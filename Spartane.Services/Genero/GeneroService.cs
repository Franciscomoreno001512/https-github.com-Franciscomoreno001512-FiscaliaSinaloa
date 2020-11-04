using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Genero;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Genero
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class GeneroService : IGeneroService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Genero.Genero> _GeneroRepository;
        #endregion

        #region Ctor
        public GeneroService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Genero.Genero> GeneroRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._GeneroRepository = GeneroRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Genero.Genero> SelAll(bool ConRelaciones)
        {
            return this._GeneroRepository.Table.ToList();
        }

        public IList<Core.Domain.Genero.Genero> SelAllComplete(bool ConRelaciones)
        {
            return this._GeneroRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Genero.Genero> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._GeneroRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Genero.Genero> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._GeneroRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Genero.Genero> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._GeneroRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Genero.GeneroPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            GeneroPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Genero.Genero> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._GeneroRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Genero.Genero GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Genero.Genero result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData GeneroInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Genero.Genero entity, Spartane.Core.Domain.User.GlobalData GeneroInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Genero.Genero entity, Spartane.Core.Domain.User.GlobalData GeneroInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

