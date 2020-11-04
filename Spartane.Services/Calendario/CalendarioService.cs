using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Calendario;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Calendario
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class CalendarioService : ICalendarioService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Calendario.Calendario> _CalendarioRepository;
        #endregion

        #region Ctor
        public CalendarioService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Calendario.Calendario> CalendarioRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._CalendarioRepository = CalendarioRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Calendario.Calendario> SelAll(bool ConRelaciones)
        {
            return this._CalendarioRepository.Table.ToList();
        }

        public IList<Core.Domain.Calendario.Calendario> SelAllComplete(bool ConRelaciones)
        {
            return this._CalendarioRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Calendario.Calendario> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._CalendarioRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Calendario.Calendario> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._CalendarioRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Calendario.Calendario> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._CalendarioRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Calendario.CalendarioPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            CalendarioPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Calendario.Calendario> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._CalendarioRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Calendario.Calendario GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Calendario.Calendario result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData CalendarioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Calendario.Calendario entity, Spartane.Core.Domain.User.GlobalData CalendarioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Calendario.Calendario entity, Spartane.Core.Domain.User.GlobalData CalendarioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

