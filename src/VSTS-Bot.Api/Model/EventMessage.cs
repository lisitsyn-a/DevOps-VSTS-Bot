﻿// ———————————————————————————————
// <copyright file="EventMessage.cs">
// Licensed under the MIT License. See License.txt in the project root for license information.
// </copyright>
// <summary>
// Represents an event message.
// </summary>
// ———————————————————————————————
namespace Vsar.TSBot
{
    /// <summary>
    /// Represents an event message.
    /// </summary>
    public class EventMessage
    {
        /// <summary>
        /// Gets or sets the html.
        /// </summary>
        public string Html { get; set; }

        /// <summary>
        /// Gets or sets the markdown.
        /// </summary>
        public string Markdown { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        public string Text { get; set; }
    }
}