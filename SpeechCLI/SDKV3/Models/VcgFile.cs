// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Speech.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// VcgFile
    /// </summary>
    public partial class VcgFile
    {
        /// <summary>
        /// Initializes a new instance of the VcgFile class.
        /// </summary>
        public VcgFile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VcgFile class.
        /// </summary>
        /// <param name="id">The identifier of this entity</param>
        /// <param name="name">The name of the object</param>
        /// <param name="editStatus">Possible values include: 'None', 'New',
        /// 'Editing', 'Completed', 'Redo', 'Approved'</param>
        /// <param name="properties">IDictionary`2</param>
        /// <param name="taskType">Possible values include: 'None', 'Folder',
        /// 'File'</param>
        /// <param name="state">Possible values include: 'None', 'Waiting',
        /// 'Processing', 'Complete', 'Failed', 'Deleting'</param>
        /// <param name="description">The description of the object</param>
        /// <param name="lastActionDateTime">The time-stamp when the current
        /// status was entered</param>
        /// <param name="status">The status of the object. Possible values
        /// include: 'NotStarted', 'Running', 'Succeeded', 'Failed'</param>
        /// <param name="createdDateTime">The time-stamp when the object was
        /// created</param>
        public VcgFile(System.Guid id, string name, System.Guid? parentId = default(System.Guid?), string editStatus = default(string), IList<VcgFolder> foldersFromRootToParent = default(IList<VcgFolder>), IDictionary<string, string> properties = default(IDictionary<string, string>), string taskType = default(string), string state = default(string), IList<string> tags = default(IList<string>), string parentIdPath = default(string), string description = default(string), System.DateTime? lastActionDateTime = default(System.DateTime?), string status = default(string), System.DateTime? createdDateTime = default(System.DateTime?))
        {
            ParentId = parentId;
            EditStatus = editStatus;
            FoldersFromRootToParent = foldersFromRootToParent;
            Properties = properties;
            TaskType = taskType;
            State = state;
            Tags = tags;
            ParentIdPath = parentIdPath;
            Id = id;
            Name = name;
            Description = description;
            LastActionDateTime = lastActionDateTime;
            Status = status;
            CreatedDateTime = createdDateTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentId")]
        public System.Guid? ParentId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'None', 'New', 'Editing',
        /// 'Completed', 'Redo', 'Approved'
        /// </summary>
        [JsonProperty(PropertyName = "editStatus")]
        public string EditStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "foldersFromRootToParent")]
        public IList<VcgFolder> FoldersFromRootToParent { get; set; }

        /// <summary>
        /// Gets or sets iDictionary`2
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'None', 'Folder', 'File'
        /// </summary>
        [JsonProperty(PropertyName = "taskType")]
        public string TaskType { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'None', 'Waiting',
        /// 'Processing', 'Complete', 'Failed', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentIdPath")]
        public string ParentIdPath { get; set; }

        /// <summary>
        /// Gets or sets the identifier of this entity
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the object
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the object
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the time-stamp when the current status was entered
        /// </summary>
        [JsonProperty(PropertyName = "lastActionDateTime")]
        public System.DateTime? LastActionDateTime { get; private set; }

        /// <summary>
        /// Gets the status of the object. Possible values include:
        /// 'NotStarted', 'Running', 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the time-stamp when the object was created
        /// </summary>
        [JsonProperty(PropertyName = "createdDateTime")]
        public System.DateTime? CreatedDateTime { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (FoldersFromRootToParent != null)
            {
                foreach (var element in FoldersFromRootToParent)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}