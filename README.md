<p align="center">
	<a href="https://github.com/StackBLU/UltimateCombo"><img align="center" src="/images/logoWide.png" width="800px"></a>
</p>

<p align="center">
	<b>Enabling you to be the pro you always dreamed of being</b><br>
	<sub>Tracks your cooldowns, buffs, job gauges, and combo state to put the right action on your button at the right time.</sub>
</p>

<p align="center">
	<img align="center" src="/images/g_blm.gif">
	<img align="center" src="/images/g_nin.gif">
	<img align="center" src="/images/g_gnb.gif">
</p>

<br>

<p align="center">
	<a href="https://discord.gg/yPxwkdqhHs" alt="Discord"><img src="https://discord.com/api/guilds/1277684496509964403/widget.png?style=banner2"></a>
</p>

<h2 align="center">
	Features
</h2>

<table align="center">
	<tr>
		<td>⚔️ <b>All Combat Jobs</b></td>
		<td>Custom PvE logic across the entire roster</td>
	</tr>
	<tr>
		<td>🎮 <b>Controller Friendly</b></td>
		<td>Designed for controller players, with a built-in button guide</td>
	</tr>
	<tr>
		<td>🔷 <b>Blue Mage</b></td>
		<td>Designed by an actual BLU player</td>
	</tr>
	<tr>
		<td>🐾 <b>Beastmaster</b></td>
		<td>Colored circles are hard</td>
	</tr>
	<tr>
		<td>🌙 <b>Field Content</b></td>
		<td>Occult Crescent, Bozja, Eureka, and Variant actions</td>
	</tr>
	<tr>
		<td>💀 <b>PvP</b></td>
		<td>Combos and instant cleansing, cuz you're pro anyways, right?</td>
	</tr>
	<tr>
		<td>🧩 <b>Modular</b></td>
		<td>Turn on exactly what you want and nothing else</td>
	</tr>
</table>

<h2 align="center">
	Installation
</h2>

<p>
	You must have <a href="https://goatcorp.github.io/">XIVLauncher/Dalamud</a> installed.
</p>

<ol>
	<li>
		Copy the repository link:<br>
		<code>https://raw.githubusercontent.com/StackBLU/UltimateCombo/main/pluginmaster.json</code>
	</li>
	<li>
		Type <code>/xlsettings</code> and navigate to <b>Experimental</b>
	</li>
	<li>
		Paste the link under <b>Custom Plugin Repositories</b> and enable it
	</li>
	<li>
		Press <b>Save and Close</b>
	</li>
	<li>
		Find <b>Ultimate Combo</b> under <b>All Plugins</b> and install it
	</li>
</ol>

<br>

<h3 align="center">
	Recommended Plugins
</h3>

<p>
	Using multiple combo plugins may produce unexpected results.
</p>

<p>
	Ultimate Combo pairs very well with the following plugins:
</p>

<ul>
	<li>
		<a href="https://github.com/UnknownX7/ReAction">ReAction</a>, for automatic target picking and turbo mode
	</li>
	<li>
		<a href="https://github.com/FFXIV-CombatReborn/BossmodReborn">BossMod Reborn</a>, for lag reduction
	</li>
	<li>
		<a href="https://github.com/PunishXIV/Avarice">Avarice</a>, for positional tells
	</li>
	<li>
		<a href="https://github.com/PunishXIV/Orbwalker">Orbwalker</a>, for slidecasting
	</li>
</ul>

<p>
	For recommended settings for each plugin, check the <tt>#recommended-settings</tt> channel in the <a href="https://discord.gg/yPxwkdqhHs">Discord</a>.
</p>

<br>

<h2 align="center">
	Configuration
</h2>

<table align="center" width="95%">
	<tr>
		<td width="33%" align="center">
			<b>1. Pick a Category and a Job</b><br><br>
			<img src="/images/guide1.png" width="100%">
		</td>
		<td width="33%" align="center">
			<b>2. Pick your combo components</b><br><br>
			<img src="/images/guide2.png" width="100%">
		</td>
		<td width="33%" align="center">
			<b>3. Configure additional settings</b><br><br>
			<img src="/images/settings.png" width="100%">
		</td>
	</tr>
</table>

<h2 align="center">
	Commands
</h2>

<p align="center">
	Enable <b>Show Internal Names</b> in settings to see each command's <code>&lt;featureName&gt;</code>.
</p>

<table align="center">
	<tr>
		<th>Commands</th>
		<th>Function</th>
	</tr>
	<tr>
		<td><code>/uc</code></td>
		<td>Opens the main plugin window, where you can enable and disable options</td>
	</tr>
	<tr>
		<td><code>/uc enable &lt;featureName&gt;</code></td>
		<td>Turns a specific option on by referring to its internal name</td>
	</tr>
	<tr>
		<td><code>/uc disable &lt;featureName&gt;</code></td>
		<td>Turns a specific option off by referring to its internal name</td>
	</tr>
	<tr>
		<td><code>/uc toggle &lt;featureName&gt;</code></td>
		<td>Toggles a specific option by referring to its internal name</td>
	</tr>
	<tr>
		<td><code>/uc enableall</code></td>
		<td>Turns all options on</td>
	</tr>
	<tr>
		<td><code>/uc disableall</code></td>
		<td>Turns all options off</td>
	</tr>
	<tr>
		<td><code>/uc gcd</code></td>
		<td>Toggles the GCD Counting setting</td>
	</tr>
	<tr>
		<td><code>/uc enabled</code></td>
		<td>Prints a list of every enabled option into the game chat</td>
	</tr>
	<tr>
		<td><code>/uc debug</code></td>
		<td>Creates a full diagnostic file on your desktop for bug reports</td>
	</tr>
	<tr>
		<td><code>/uc debug &lt;jobShort&gt;</code></td>
		<td>The above, but just for one job</td>
	</tr>
</table>

<h2 align="center">
	Issues
</h2>

<p align="center">
	<a href="https://github.com/StackBLU/UltimateCombo/issues"><img src="https://img.shields.io/badge/Report_Issue-GitHub-d73a49?style=for-the-badge&logo=github"></a>
</p>

<p align="center">
	If you experience any bugs or errors, please create an issue on GitHub or join the <a href="https://discord.gg/yPxwkdqhHs">Discord</a>.<br>
	Use <code>/uc debug</code> to create a diagnostic file to attach to your report. 
</p>

<p align="center">
	Developed by:<br>
	<a href="https://github.com/StackBLU"><img align="center" src="/images/stack.png" width="220px"></a>
</p>