using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Lugares_Frecuentes_Requerido_MASC;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Lugares_Frecuentes_Requerido_MASC
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Lugares_Frecuentes_Requerido_MASCService : ILugares_Frecuentes_Requerido_MASCService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Lugares_Frecuentes_Requerido_MASC.Lugares_Frecuentes_Requerido_MASC> _Lugares_Frecuentes_Requerido_MASCRepository;
        #endregion

        #region Ctor
        public Lugares_Frecuentes_Requerido_MASCService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Lugares_Frecuentes_Requerido_MASC.Lugares_Frecuentes_Requerido_MASC> Lugares_Frecuentes_Requerido_MASCRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Lugares_Frecuentes_Requerido_MASCRepository = Lugares_Frecuentes_Requerido_MASCRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Lugares_Frecuentes_Requerido_MASC.Lugares_Frecuentes_Requerido_MASC> SelAll(bool ConRelaciones)
        {
            return this._Lugares_Frecuentes_Requerido_MASCRepository.Table.ToList();
        }

        public IList<Core.Domain.Lugares_Frecuentes_Requerido_MASC.Lugares_Frecuentes_Requerido_MASC> SelAllComplete(bool ConRelaciones)
        {
            return this._Lugares_Frecuentes_Requerido_MASCRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Lugares_Frecuentes_Requerido_MASC.Lugares_Frecuentes_Requerido_MASC> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Lugares_Frecuentes_Requerido_MASCRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Lugares_Frecuentes_Requerido_MASC.Lugares_Frecuentes_Requerido_MASC> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Lugares_Frecuentes_Requerido_MASCRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Lugares_Frecuentes_Requerido_MASC.Lugares_Frecuentes_Requerido_MASC> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Lugares_Frecuentes_Requerido_MASCRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Lugares_Frecuentes_Requerido_MASC.Lugares_Frecuentes_Requerido_MASCPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Lugares_Frecuentes_Requerido_MASCPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Lugares_Frecuentes_Requerido_MASC.Lugares_Frecuentes_Requerido_MASC> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Lugares_Frecuentes_Requerido_MASCRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Lugares_Frecuentes_Requerido_MASC.Lugares_Frecuentes_Requerido_MASC GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Lugares_Frecuentes_Requerido_MASC.Lugares_Frecuentes_Requerido_MASC result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Lugares_Frecuentes_Requerido_MASCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Lugares_Frecuentes_Requerido_MASC.Lugares_Frecuentes_Requerido_MASC entity, Spartane.Core.Domain.User.GlobalData Lugares_Frecuentes_Requerido_MASCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Lugares_Frecuentes_Requerido_MASC.Lugares_Frecuentes_Requerido_MASC entity, Spartane.Core.Domain.User.GlobalData Lugares_Frecuentes_Requerido_MASCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

