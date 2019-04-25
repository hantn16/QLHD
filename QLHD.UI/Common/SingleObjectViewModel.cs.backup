
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using System;
using System.Linq;
using System.Reflection;

namespace QLHD.UI.Common
{
    /// <summary>
    /// The base class for POCO view models exposing a single entity of a given type and CRUD operations against this entity.
    /// This is a partial class that provides the extension point to add custom properties, commands and override methods without modifying the auto-generated code.
    /// </summary>
    /// <typeparam name="TEntity">An entity type.</typeparam>
    /// <typeparam name="TPrimaryKey">A primary key value type.</typeparam>
    /// <typeparam name="TUnitOfWork">A unit of work type.</typeparam>
    public abstract partial class SingleObjectViewModel<TEntity, TPrimaryKey, TUnitOfWork> : SingleObjectViewModelBase<TEntity, TPrimaryKey, TUnitOfWork>
        where TEntity : class
        where TUnitOfWork : IUnitOfWork {

        /// <summary>
        /// Initializes a new instance of the SingleObjectViewModel class.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create the unit of work instance.</param>
        /// <param name="getRepositoryFunc">A function that returns the repository representing entities of a given type.</param>
        /// <param name="getEntityDisplayNameFunc">An optional parameter that provides a function to obtain the display text for a given entity. If ommited, the primary key value is used as a display text.</param>
        protected SingleObjectViewModel(IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory, Func<TUnitOfWork, IRepository<TEntity, TPrimaryKey>> getRepositoryFunc, Func<TEntity, object> getEntityDisplayNameFunc = null)
            : base(unitOfWorkFactory, getRepositoryFunc, getEntityDisplayNameFunc) {
        }
        protected override void OnBeforeEntitySaved(TPrimaryKey primaryKey, TEntity entity, bool isNewEntity)
        {
            base.OnBeforeEntitySaved(primaryKey, entity, isNewEntity);
            if (isNewEntity)
            {
                SetAuditablePropertiesForCreate(entity);
            }
            else
            {
                SetAuditablePropertiesForModify(entity);
            }


        }
        void SetAuditablePropertiesForCreate(object obj)
        {
            SetTimeForObject(obj, "CreatedAt", DateTime.Now);
            SetPersonForObject(obj, "CreatedBy", ConstantVariable.CurrentUserName);
        }
        void SetAuditablePropertiesForModify(object obj)
        {
            SetTimeForObject(obj, "ModifiedAt", DateTime.Now);
            SetPersonForObject(obj, "ModifiedBy", ConstantVariable.CurrentUserName);
        }
        void SetTimeForObject(object obj, string propName, DateTime dateTime)
        {
            PropertyInfo propInfo = obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .FirstOrDefault(x => x.Name.Equals(propName, StringComparison.OrdinalIgnoreCase));
            if (propInfo != null)
            {
                propInfo.SetValue(obj, dateTime);
            }
        }
        void SetPersonForObject(object obj, string propName, string personName)
        {
            PropertyInfo propInfo = obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .FirstOrDefault(x => x.Name.Equals(propName, StringComparison.OrdinalIgnoreCase));
            if (propInfo != null)
            {
                propInfo.SetValue(obj, personName);
            }
        }
        public string currentUser { get; set; }
        void SetCurrentUser(string username)
        {
            currentUser = username;            
        }
    }
}