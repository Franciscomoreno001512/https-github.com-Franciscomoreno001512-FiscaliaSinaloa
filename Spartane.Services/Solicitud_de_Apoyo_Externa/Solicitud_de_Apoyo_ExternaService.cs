using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Solicitud_de_Apoyo_Externa;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Solicitud_de_Apoyo_Externa
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Solicitud_de_Apoyo_ExternaService : ISolicitud_de_Apoyo_ExternaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa> _Solicitud_de_Apoyo_ExternaRepository;
        #endregion

        #region Ctor
        public Solicitud_de_Apoyo_ExternaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa> Solicitud_de_Apoyo_ExternaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Solicitud_de_Apoyo_ExternaRepository = Solicitud_de_Apoyo_ExternaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa> SelAll(bool ConRelaciones)
        {
            return this._Solicitud_de_Apoyo_ExternaRepository.Table.ToList();
        }

        public IList<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa> SelAllComplete(bool ConRelaciones)
        {
            return this._Solicitud_de_Apoyo_ExternaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Solicitud_de_Apoyo_ExternaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Solicitud_de_Apoyo_ExternaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Solicitud_de_Apoyo_ExternaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_ExternaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Solicitud_de_Apoyo_ExternaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Solicitud_de_Apoyo_ExternaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Solicitud_de_Apoyo_ExternaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa entity, Spartane.Core.Domain.User.GlobalData Solicitud_de_Apoyo_ExternaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa entity, Spartane.Core.Domain.User.GlobalData Solicitud_de_Apoyo_ExternaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

