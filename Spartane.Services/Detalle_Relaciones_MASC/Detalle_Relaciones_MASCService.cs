using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Relaciones_MASC;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Relaciones_MASC
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Relaciones_MASCService : IDetalle_Relaciones_MASCService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Relaciones_MASC.Detalle_Relaciones_MASC> _Detalle_Relaciones_MASCRepository;
        #endregion

        #region Ctor
        public Detalle_Relaciones_MASCService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Relaciones_MASC.Detalle_Relaciones_MASC> Detalle_Relaciones_MASCRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Relaciones_MASCRepository = Detalle_Relaciones_MASCRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Relaciones_MASC.Detalle_Relaciones_MASC> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Relaciones_MASCRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Relaciones_MASC.Detalle_Relaciones_MASC> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Relaciones_MASCRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Relaciones_MASC.Detalle_Relaciones_MASC> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Relaciones_MASCRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Relaciones_MASC.Detalle_Relaciones_MASC> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Relaciones_MASCRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Relaciones_MASC.Detalle_Relaciones_MASC> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Relaciones_MASCRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Relaciones_MASC.Detalle_Relaciones_MASCPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Relaciones_MASCPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Relaciones_MASC.Detalle_Relaciones_MASC> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Relaciones_MASCRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Relaciones_MASC.Detalle_Relaciones_MASC GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Relaciones_MASC.Detalle_Relaciones_MASC result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Relaciones_MASCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Relaciones_MASC.Detalle_Relaciones_MASC entity, Spartane.Core.Domain.User.GlobalData Detalle_Relaciones_MASCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Relaciones_MASC.Detalle_Relaciones_MASC entity, Spartane.Core.Domain.User.GlobalData Detalle_Relaciones_MASCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

