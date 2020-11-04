using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Circunstancia_Defuncion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Circunstancia_Defuncion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Circunstancia_DefuncionService : ICircunstancia_DefuncionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Circunstancia_Defuncion.Circunstancia_Defuncion> _Circunstancia_DefuncionRepository;
        #endregion

        #region Ctor
        public Circunstancia_DefuncionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Circunstancia_Defuncion.Circunstancia_Defuncion> Circunstancia_DefuncionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Circunstancia_DefuncionRepository = Circunstancia_DefuncionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Circunstancia_Defuncion.Circunstancia_Defuncion> SelAll(bool ConRelaciones)
        {
            return this._Circunstancia_DefuncionRepository.Table.ToList();
        }

        public IList<Core.Domain.Circunstancia_Defuncion.Circunstancia_Defuncion> SelAllComplete(bool ConRelaciones)
        {
            return this._Circunstancia_DefuncionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Circunstancia_Defuncion.Circunstancia_Defuncion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Circunstancia_DefuncionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Circunstancia_Defuncion.Circunstancia_Defuncion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Circunstancia_DefuncionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Circunstancia_Defuncion.Circunstancia_Defuncion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Circunstancia_DefuncionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Circunstancia_Defuncion.Circunstancia_DefuncionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Circunstancia_DefuncionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Circunstancia_Defuncion.Circunstancia_Defuncion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Circunstancia_DefuncionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Circunstancia_Defuncion.Circunstancia_Defuncion GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Circunstancia_Defuncion.Circunstancia_Defuncion result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Circunstancia_DefuncionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Circunstancia_Defuncion.Circunstancia_Defuncion entity, Spartane.Core.Domain.User.GlobalData Circunstancia_DefuncionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Circunstancia_Defuncion.Circunstancia_Defuncion entity, Spartane.Core.Domain.User.GlobalData Circunstancia_DefuncionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

