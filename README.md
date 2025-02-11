# RespawnTimer
Displays a timer until the spawn of MTF and CI for [CustomHint](https://github.com/BTF-SCPSL/CustomHint).  
Placeholders:
- Time until MTF spawn: `{respawn_mtf}`
- Time until CI spawn: `{respawn_ci}`

## Configs
`Config.yml`:
```yaml
respawn_timer:
# Placeholder enabled (bool)?
  is_enabled: true
  # Debug mode.
  debug: false
```
`Translation.yml`:
```yaml
respawn_timer:
# Format for the MTF respawn timer.
  mtf_respawn_format: '{minutes} min. {seconds} sec.'
  # Format for the Chaos Insurgency respawn timer.
  chaos_respawn_format: '{minutes} min. {seconds} sec.'
  # Format when no respawn is scheduled.
  no_respawn_format: 'Waiting...'
```
