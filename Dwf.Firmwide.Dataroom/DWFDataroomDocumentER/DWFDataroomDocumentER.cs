﻿using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;
using System.Runtime.InteropServices;
using Microsoft.SharePoint;

namespace Dwf.Firmwide.Dataroom.DWFDataroomDocumentER
{
    /// <summary>
    /// List Item Events
    /// </summary>
    [Guid("ec181fb2-9482-41fe-83d6-4ac50cb428cc")]
    public class DWFDataroomDocumentER : SPItemEventReceiver
    {
        /// <summary>
        /// An item is being added.
        /// </summary>
        public override void ItemAdding(SPItemEventProperties properties)
        {
            base.ItemAdding(properties);
        }

        /// <summary>
        /// An item is being updated.
        /// </summary>
        public override void ItemUpdating(SPItemEventProperties properties)
        {
            base.ItemUpdating(properties);
        }

        /// <summary>
        /// An item is being deleted.
        /// </summary>
        public override void ItemDeleting(SPItemEventProperties properties)
        {
            base.ItemDeleting(properties);
        }

        /// <summary>
        /// An attachment is being added to the item.
        /// </summary>
        public override void ItemAttachmentAdding(SPItemEventProperties properties)
        {
            base.ItemAttachmentAdding(properties);
        }

        /// <summary>
        /// An attachment is being removed from the item.
        /// </summary>
        public override void ItemAttachmentDeleting(SPItemEventProperties properties)
        {
            base.ItemAttachmentDeleting(properties);
        }

        /// <summary>
        /// An item was added.
        /// </summary>
        public override void ItemAdded(SPItemEventProperties properties)
        {
            base.ItemAdded(properties);
        }

        /// <summary>
        /// An item was updated.
        /// </summary>
        public override void ItemUpdated(SPItemEventProperties properties)
        {
            base.ItemUpdated(properties);
        }

        /// <summary>
        /// An item was deleted.
        /// </summary>
        public override void ItemDeleted(SPItemEventProperties properties)
        {
            base.ItemDeleted(properties);
        }


    }
}