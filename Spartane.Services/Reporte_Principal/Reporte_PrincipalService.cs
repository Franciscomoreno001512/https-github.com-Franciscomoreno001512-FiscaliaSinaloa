using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Reporte_Principal;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Reporte_Principal
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Reporte_PrincipalService : IReporte_PrincipalService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal> _Reporte_PrincipalRepository;
        #endregion

        #region Ctor
        public Reporte_PrincipalService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal> Reporte_PrincipalRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Reporte_PrincipalRepository = Reporte_PrincipalRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal> SelAll(bool ConRelaciones)
        {
            return this._Reporte_PrincipalRepository.Table.ToList();
        }

        public IList<Core.Domain.Reporte_Principal.Reporte_Principal> SelAllComplete(bool ConRelaciones)
        {
            return this._Reporte_PrincipalRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Reporte_PrincipalRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Reporte_PrincipalRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Reporte_PrincipalRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Reporte_Principal.Reporte_PrincipalPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Reporte_PrincipalPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Reporte_PrincipalRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Reporte_Principal.Reporte_Principal GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Reporte_Principal.Reporte_Principal result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Reporte_PrincipalInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Reporte_Principal.Reporte_Principal entity, Spartane.Core.Domain.User.GlobalData Reporte_PrincipalInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Reporte_Principal.Reporte_Principal entity, Spartane.Core.Domain.User.GlobalData Reporte_PrincipalInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

