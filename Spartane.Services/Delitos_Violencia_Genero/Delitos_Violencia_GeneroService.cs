using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Delitos_Violencia_Genero;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Delitos_Violencia_Genero
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Delitos_Violencia_GeneroService : IDelitos_Violencia_GeneroService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero> _Delitos_Violencia_GeneroRepository;
        #endregion

        #region Ctor
        public Delitos_Violencia_GeneroService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero> Delitos_Violencia_GeneroRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Delitos_Violencia_GeneroRepository = Delitos_Violencia_GeneroRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero> SelAll(bool ConRelaciones)
        {
            return this._Delitos_Violencia_GeneroRepository.Table.ToList();
        }

        public IList<Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero> SelAllComplete(bool ConRelaciones)
        {
            return this._Delitos_Violencia_GeneroRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Delitos_Violencia_GeneroRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Delitos_Violencia_GeneroRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Delitos_Violencia_GeneroRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_GeneroPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Delitos_Violencia_GeneroPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Delitos_Violencia_GeneroRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Delitos_Violencia_GeneroInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero entity, Spartane.Core.Domain.User.GlobalData Delitos_Violencia_GeneroInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero entity, Spartane.Core.Domain.User.GlobalData Delitos_Violencia_GeneroInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

