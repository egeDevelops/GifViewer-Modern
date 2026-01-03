# GIF Viewer (2026 Modernized Fork)

A modernized fork of the classic GIF Viewer originally hosted on SourceForge. This version has been rescued from legacy codebases, upgraded to .NET 4.8.1, and optimized for modern Windows environments.

## Overview
This project is a fork of the original GIF Viewer created by p_reagan in 2013. As the original project has been dormant for over a decade, this fork aims to keep the utility alive and functional for the modern era by implementing native Windows 11/12 features and streamlining the user experience.

## Changes
- **Framework Upgrade**: Migrated from .NET 4.5 to .NET 4.8.1 for improved high-DPI support, better stability, and modern runtime optimizations.
- **Modern Tooling**: Full compatibility with Visual Studio 2022/2026 and modern MSBuild workflows.
- **Dependency Fixes**: Resolved legacy resource serialization issues (MSB3822) encountered during the migration from older environments.
- **Fluent Design Integration**: Implemented native Windows 11/12 Mica material effects (Attribute 38) and rounded corner preferences (Attribute 33) via DWM Interop.
- **Dark Mode Support**: Added system-aware dark theme support for the title bar and main window frames (Attribute 20).
- **UX Refinement**: Streamlined the context menu to prioritize internal file navigation over legacy external program "pinning," reducing UI clutter and focusing on core viewer functionality.
- **Repository Maintenance**: Standardized project structure and implemented `.gitignore` best practices to ensure a clean development environment.

## License
This project is licensed under the GNU General Public License v3.0—the same license as the original source code. See the LICENSE file for details.

---
**Original Project**: [GIF Viewer on SourceForge](https://sourceforge.net/projects/gifviewer/)
