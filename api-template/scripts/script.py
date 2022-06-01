from templateframework.metadata import Metadata
import requests

def run(metadata: Metadata = None):
    url = "http://runtime-engine-api.runtime-controlplane.sbox.stackspot.com/apps/"
    headers = {"Content-Type": "application/json"}
    data = {
        "name": f"{metadata.global_computed_inputs['project_name_formated']}",
    }
    response = requests.put(url, headers=headers, json=data)
    if(response.status_code != 201):
        print(f"Error runtine-engine: {response.status_code}")
    
    metadata.global_inputs['app_runtime_id'] = response.json()['id']

    return metadata