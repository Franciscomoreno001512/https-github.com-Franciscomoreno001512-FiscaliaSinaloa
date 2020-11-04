using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_de_Tutor;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_de_Tutor
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_de_TutorService : IDetalle_de_TutorService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_de_Tutor.Detalle_de_Tutor> _Detalle_de_TutorRepository;
        #endregion

        #region Ctor
        public Detalle_de_TutorService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_de_Tutor.Detalle_de_Tutor> Detalle_de_TutorRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_de_TutorRepository = Detalle_de_TutorRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Tutor.Detalle_de_Tutor> SelAll(bool ConRelaciones)
        {
            return this._Detalle_de_TutorRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_de_Tutor.Detalle_de_Tutor> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_de_TutorRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_de_Tutor.Detalle_de_Tutor> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_TutorRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Tutor.Detalle_de_Tutor> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_de_TutorRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Tutor.Detalle_de_Tutor> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_TutorRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Tutor.Detalle_de_TutorPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_de_TutorPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Tutor.Detalle_de_Tutor> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_de_TutorRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Tutor.Detalle_de_Tutor GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_de_Tutor.Detalle_de_Tutor result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_TutorInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_de_Tutor.Detalle_de_Tutor entity, Spartane.Core.Domain.User.GlobalData Detalle_de_TutorInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_de_Tutor.Detalle_de_Tutor entity, Spartane.Core.Domain.User.GlobalData Detalle_de_TutorInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

