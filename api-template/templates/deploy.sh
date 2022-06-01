#!/bin/bash    
curl --location --request PUT 'http://runtime-engine-api.runtime-controlplane.sbox.stackspot.com/apps/{{global_inputs.app_runtime_id}}/deploys/' \
--header 'Content-Type: multipart/form-data' \
--form 'spec=@"{{target_path}}/oam.yaml"' \
--form 'target="b448700c-33d9-4c8c-9852-3cd9425c3d58"' 