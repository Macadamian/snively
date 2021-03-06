# "Snively" Note-Taking App

Copyright (C) 2012 Macadamian

See COPYING for license details.

Andrew Clunis <aclunis@macadamian.com>

## Synopsis

The goal is to create a means for a person to capture ideas, tasks, and thoughts in order to track their affairs and then prioritize them.

It achieves this by reducing all this to a simple structure of Notes that contain rich (Markdown) text content and an ordered list of links to other Notes.  In addition, they have a progress field and some other miscellaneous metadata.

This permits the user to create whatever emergent workflow best suits their requirements (tracking a general TODO list, tracking personal priorities on a given project, tracking grocery lists, and so on).

Thoughts relevant or otherwise to current work often appear unbidden in one's brain: provide a very fast means to capture them for further consideration at a later time.


Most of these user stories apply equally to mobile and desktop.

## User Stories

### Browsing and Displaying Notes

Starting at the home (first) screen, the user will see starred notes, recently used notes, frequently used notes, and any root notes.

Tapping/clicking on a note will navigate your pane to that note.  Action bar/breadcrumbs along the top of the display will allow easy backtracking from whence you came (note that because the notes are not in a flat hierarchy, different routes can take you to the same note).

#### Navigation

##### Mobile

A split view, for two navigation threads of notes at once.

You may use a horizontal swipe gesture to switch between left and right panes.

The panes contain the view of one note:

You may tap the breadcrumbs along the top of the pane in order to return along their path of arrival.

Tap the text tab to see and edit the text 

You may tap the description contents area to free-form edit text contained within this note.

##### Desktop

Multiple windows.  Window may be splittable.



Desktop app offers multiple 

### Inserting a Note

Inside a host note, tap the last, "Insert..." entry, to begin typing a new note title inline.  Finishing text entry returns you to the parents' note list, as you were before.  This enables fast line-item entry.

### Search

- case insensitive full-word indexing
- if you match a note title, it should match the parents that contain that note

### Editing a Note

Tapping on a note will yield a new note detail screen.  You can see the nested notes here, or edit the detail text (on mobile, 

### Fast capture

#### Workstation

A thing worth remembering strikes your mind as you're busy working.  Capture it quickly by striking a hotkey, and type your quick thought into a presented notification/dialog box.  THe app files the note within a conventional "Incoming" note, for user's later consideration (the "Incoming" note is a standard note, but is identified by convention -- or, at least, default configuration -- as a target for incoming notes being entered in some out-of-band fasion).

#### Mobile

Android share intent filter that most apps can use to shove things into a new note.

### Priority ordering

You encode priority kinetically, by dragging and dropping the linked notes in the list within a note.

### Categorization

You can drag and drop notes between the ordered lists in order to move them.  On desktop, hold down some modifier key or other in order to make a new link, rather than move the note entirely (ie., not just retarget the selected link).

### Prioritization session

By using the kinetic prioritization and ordering, you can systematically address all the newly collected notes over the course of the day by looking at the "Incoming" note and its contents, and file them into appropriate categories and prioritize them as needed.

### Synchronization

You own several devices, a smartphone, a tablet, an office workstation, and a laptop.

Add a note on your smartphone, but no network is available.  When network becomes available, the notes appears on their your devices.

Modify a note on your laptop.  Later, you go out of service area with your smartphone, and modify the same note.  When you arrive back in service area, and look at your notes on the laptop, the modification appears there.

Modify a note on your laptop.  Later, you go out of service area with your smartphone, and modify the same note.  Then, you arrive back in service area with your phone, but you leave it in airplane mode.  You make a different modification on your laptop to the same note on your laptop.  Then, you reenable the radio on your smartphone, which begins sync.  There is a conflict: both devices show (with a red indicator bar in the note, or similar UI pattern) that note as conflicted, and you must select which version to keep.

### Example Contents

### Extra Credit

#### External sources

User adds an external source, such as Jira, ChiliProject, or GitHub Issues.

User finds virtual notes that contain their issues (and their categories) from those services ready for linking and prioritization, as always.

Tomboy importer.

### Integration Points

Extensions for mail readers, web browsers for taking content and tossing it into a note

## Technical Requirements

### Data Model

Regardless of network availability, their content is always available on all their devices.  Devices automatically achieve eventual consistency as network becomes available.  If conflicts occur, 
