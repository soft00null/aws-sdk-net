/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents additional information about a job required for a job worker to complete
    /// the job.
    /// </summary>
    public partial class JobData
    {
        private ActionConfiguration _actionConfiguration;
        private ActionTypeId _actionTypeId;
        private AWSSessionCredentials _artifactCredentials;
        private string _continuationToken;
        private EncryptionKey _encryptionKey;
        private List<Artifact> _inputArtifacts = new List<Artifact>();
        private List<Artifact> _outputArtifacts = new List<Artifact>();
        private PipelineContext _pipelineContext;

        /// <summary>
        /// Gets and sets the property ActionConfiguration.
        /// </summary>
        public ActionConfiguration ActionConfiguration
        {
            get { return this._actionConfiguration; }
            set { this._actionConfiguration = value; }
        }

        // Check to see if ActionConfiguration property is set
        internal bool IsSetActionConfiguration()
        {
            return this._actionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ActionTypeId.
        /// </summary>
        public ActionTypeId ActionTypeId
        {
            get { return this._actionTypeId; }
            set { this._actionTypeId = value; }
        }

        // Check to see if ActionTypeId property is set
        internal bool IsSetActionTypeId()
        {
            return this._actionTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property ArtifactCredentials.
        /// </summary>
        public AWSSessionCredentials ArtifactCredentials
        {
            get { return this._artifactCredentials; }
            set { this._artifactCredentials = value; }
        }

        // Check to see if ArtifactCredentials property is set
        internal bool IsSetArtifactCredentials()
        {
            return this._artifactCredentials != null;
        }

        /// <summary>
        /// Gets and sets the property ContinuationToken. 
        /// <para>
        /// A system-generated token, such as a AWS CodeDeploy deployment ID, that a job requires
        /// in order to continue the job asynchronously.
        /// </para>
        /// </summary>
        public string ContinuationToken
        {
            get { return this._continuationToken; }
            set { this._continuationToken = value; }
        }

        // Check to see if ContinuationToken property is set
        internal bool IsSetContinuationToken()
        {
            return this._continuationToken != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKey.
        /// </summary>
        public EncryptionKey EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }

        // Check to see if EncryptionKey property is set
        internal bool IsSetEncryptionKey()
        {
            return this._encryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property InputArtifacts. 
        /// <para>
        /// The artifact supplied to the job.
        /// </para>
        /// </summary>
        public List<Artifact> InputArtifacts
        {
            get { return this._inputArtifacts; }
            set { this._inputArtifacts = value; }
        }

        // Check to see if InputArtifacts property is set
        internal bool IsSetInputArtifacts()
        {
            return this._inputArtifacts != null && this._inputArtifacts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OutputArtifacts. 
        /// <para>
        /// The output of the job.
        /// </para>
        /// </summary>
        public List<Artifact> OutputArtifacts
        {
            get { return this._outputArtifacts; }
            set { this._outputArtifacts = value; }
        }

        // Check to see if OutputArtifacts property is set
        internal bool IsSetOutputArtifacts()
        {
            return this._outputArtifacts != null && this._outputArtifacts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PipelineContext.
        /// </summary>
        public PipelineContext PipelineContext
        {
            get { return this._pipelineContext; }
            set { this._pipelineContext = value; }
        }

        // Check to see if PipelineContext property is set
        internal bool IsSetPipelineContext()
        {
            return this._pipelineContext != null;
        }

    }
}