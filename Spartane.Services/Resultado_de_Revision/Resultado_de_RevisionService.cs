using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Resultado_de_Revision;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Resultado_de_Revision
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Resultado_de_RevisionService : IResultado_de_RevisionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision> _Resultado_de_RevisionRepository;
        #endregion

        #region Ctor
        public Resultado_de_RevisionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision> Resultado_de_RevisionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Resultado_de_RevisionRepository = Resultado_de_RevisionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision> SelAll(bool ConRelaciones)
        {
            return this._Resultado_de_RevisionRepository.Table.ToList();
        }

        public IList<Core.Domain.Resultado_de_Revision.Resultado_de_Revision> SelAllComplete(bool ConRelaciones)
        {
            return this._Resultado_de_RevisionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Resultado_de_RevisionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Resultado_de_RevisionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Resultado_de_RevisionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_RevisionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Resultado_de_RevisionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Resultado_de_RevisionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Resultado_de_RevisionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision entity, Spartane.Core.Domain.User.GlobalData Resultado_de_RevisionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision entity, Spartane.Core.Domain.User.GlobalData Resultado_de_RevisionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

