import json, os, sys, time

repo_path = sys.argv[1]
version = sys.argv[2]
repo_full_name = sys.argv[3]
channel = sys.argv[4] if len(sys.argv) > 4 else 'stable'
tag = sys.argv[5] if len(sys.argv) > 5 else f"v{version}"

json_path = os.path.join(repo_path, 'pluginmaster.json')

with open(json_path, 'r', encoding='utf-8') as f:
    data = json.load(f)

download_url = f"https://github.com/{repo_full_name}/releases/download/{tag}/latest.zip"

idx = next((i for i, e in enumerate(data) if e.get('InternalName') == 'InventoryTools'), -1)

if channel == 'testing':
    # dev branch: only update testing fields
    entry = data[idx] if idx >= 0 else {}
    entry['InternalName'] = 'InventoryTools'
    entry['DownloadLinkTesting'] = download_url
    entry['TestingAssemblyVersion'] = version
    entry['TestingDalamudApiLevel'] = 15
    entry['LastUpdate'] = int(time.time())
else:
    # stable branch: full update
    entry = {
        'Name': 'Allagan Tools',
        'Author': 'Critical_Impact, QianChangUwU(汉化)',
        'Punchline': '在FFXIV中整理物品，轻松定位/显示物品的存放位置，规划你的制作，以及搜索怪物、任务、飞空艇和潜水艇！',
        'Description': 'Allagan Tool的主要用途是追踪你在各个角色/雇员/部队中的物品。借助其筛选系统，你再也不会找不到物品或不知道它们应该归类到哪里。\n\n虽然这是它的主要功能，但它还拥有一份相当详尽的其他功能列表，包括：\n\t- 制作规划\n\t- 市场板整合\n\t- 在搜索/分类以及挑选制作材料时，在背包中高亮显示物品\n\t- 包含商人及来源等信息的物品窗口\n\t- 完全可搜索的任务/怪物/飞空艇/潜水艇窗口\n\t- 一个筛选系统，让你可以为特定物品设置复杂搜索\n\t- 提示框整合，让你在悬停时即可查看物品位置',
        'InternalName': 'InventoryTools',
        'AssemblyVersion': version,
        'TestingAssemblyVersion': version,
        'DalamudApiLevel': 15,
        'TestingDalamudApiLevel': 15,
        'DownloadLinkInstall': download_url,
        'DownloadLinkUpdate': download_url,
        'DownloadLinkTesting': download_url,
        'RepoUrl': f'https://github.com/{repo_full_name}',
        'IconUrl': 'https://raw.githubusercontent.com/QianChangUwU/InventoryTools/main/InventoryTools/Images/icon.png',
        'Tags': ['Inventory', 'Sorting', 'Filtering', 'cn'],
        'ApplicableVersion': 'any',
        'LoadPriority': 0,
        'AcceptsFeedback': True,
        'LastUpdate': int(time.time()),
    }

idx = next((i for i, e in enumerate(data) if e.get('InternalName') == 'InventoryTools'), -1)
if idx >= 0:
    data[idx] = entry
else:
    data.append(entry)

with open(json_path, 'w', encoding='utf-8') as f:
    json.dump(data, f, indent=4, ensure_ascii=False)
